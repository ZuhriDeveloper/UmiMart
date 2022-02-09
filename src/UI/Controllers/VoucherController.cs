using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.Vouchers.Queries;
using UMApplication.Application.Vouchers.Queries.GetVoucherList;
using UMApplication.Application.Vouchers.Commands.UpsertVoucher;
using System.Text;
using UMApplication.Domain.Common;

namespace UMApplication.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class VoucherController : Controller
    {
        public async Task<IActionResult> Index()
        {

            VoucherListVm voucherList = await GetListVoucherAsync();

            return View(voucherList.Vouchers);
        }

        private async Task<VoucherListVm> GetListVoucherAsync()
        {
            VoucherListVm voucherList = new VoucherListVm();
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/VoucherApi/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    voucherList = JsonConvert.DeserializeObject<VoucherListVm>(apiResponse);
                }
            }

            return voucherList;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(int id)
        {
            UpsertVoucherCommand data = new UpsertVoucherCommand();

            if (id != 0)
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(baseUrl + "/api/VoucherApi/" + id.ToString()))
                    {
                        VoucherDto detail;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        detail = JsonConvert.DeserializeObject<VoucherDto>(apiResponse);
                        data.VoucherId = detail.VoucherId;
                        data.VoucherCode = detail.VoucherCode;
                        data.Status = detail.Status;
                        data.No_Faktur = detail.No_Faktur;
                        data.Nominal = Convert.ToDecimal(detail.Nominal);
                        //data.ValidFrom = detail.ValidFrom;
                        //data.ValidTo = detail.ValidTo;
                        //data.UsageDate = detail.UsageDate;
                    }
                }
            }


            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UpsertVoucherCommand data)
        {
            try
            {
                if(data.VoucherId == 0)
                {
                    bool isValidCode = await ValidateVoucherCodeAsync(data.VoucherCode);

                    if (!isValidCode)
                    {
                        TempData["Error"] = "Kode Voucher sudah terdaftar";
                        return RedirectToAction("Create", 0);
                    }
                }
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                MappingDate(data);
                var json = JsonConvert.SerializeObject(data);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/VoucherApi", httpData))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            if (data.VoucherId == 0)
                                TempData["Message"] = "Voucher berhasil ditambahkan";
                            else
                                TempData["Message"] = "Voucher berhasil diupdate";

                            return RedirectToAction("Create", 0);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        sb.Append(error.ErrorMessage);
                    }
                }

                TempData["Error"] = sb.ToString();
            }
            return RedirectToAction("Create", data.VoucherId);
        }

        private async Task<bool> ValidateVoucherCodeAsync(string voucherCode)
        {
            VoucherListVm voucherList = await GetListVoucherAsync();
            var existingVoucher = voucherList.Vouchers.Where(x => x.VoucherCode.ToLower() == voucherCode.ToLower()).FirstOrDefault();
            if (existingVoucher != null)
            {

                return false;
            }

            return true;
        }

        private void MappingDate(UpsertVoucherCommand data)
        {
            try
            {
                data.ValidFrom = Convert.ToDateTime(data.ValidFromString);
            }
            catch (Exception)
            {

            }

            try
            {
                if (!string.IsNullOrWhiteSpace(data.ValidToString))
                    data.ValidTo = Convert.ToDateTime(data.ValidToString);
            }
            catch (Exception)
            {
                data.ValidTo = null;
            }
        }
    }
}
