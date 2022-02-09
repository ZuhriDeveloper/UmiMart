using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.Suppliers.Queries;
using UMApplication.Application.Suppliers.Queries.GetSupplierList;
using UMApplication.Application.Suppliers.Queries.GetSupplierDetail;
using UMApplication.Application.Suppliers.Commands.UpsertSupplier;
using System.Text;

namespace UMApplication.UI.Controllers
{
    public class SupplierController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            SupplierListVm SupplierList = new SupplierListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/SupplierApi"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    SupplierList = JsonConvert.DeserializeObject<SupplierListVm>(apiResponse);
                }
            }
            return View(SupplierList.Suppliers);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(int id)
        {
            UpsertSupplierCommand data = new UpsertSupplierCommand();

            if (id != 0)
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(baseUrl + "/api/SupplierApi/" + id.ToString()))
                    {
                        SupplierDto detail;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        detail = JsonConvert.DeserializeObject<SupplierDto>(apiResponse);

                        data.Id = detail.Id;
                        data.Nama = detail.Nama;
                        data.ContactPerson = detail.ContactPerson;
                        data.Telepon = detail.Telepon;
                        data.Handphone = detail.Handphone;
                        data.Email = detail.Email;
                        data.Alamat = detail.Alamat;
                        data.IsActive = true;
                    }
                }
            }


            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(UpsertSupplierCommand data)
        {
            try
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                data.IsActive = true;
                var json = JsonConvert.SerializeObject(data);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/SupplierApi", httpData))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            if (data.Id == 0)
                                TempData["Message"] = "Supplier berhasil ditambahkan";
                            else
                                TempData["Message"] = "Supplier berhasil diubah";

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
            return RedirectToAction("Create",data.Id);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            try
            {
                UpsertSupplierCommand data = new UpsertSupplierCommand();

                if (id != 0)
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.GetAsync(baseUrl + "/api/SupplierApi/" + id.ToString()))
                        {
                            SupplierDto detail;
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            detail = JsonConvert.DeserializeObject<SupplierDto>(apiResponse);


                            data.Id = detail.Id;
                            data.Nama = detail.Nama;
                            data.Alamat = detail.Alamat;
                            data.ContactPerson = detail.ContactPerson;
                            data.Telepon = detail.Telepon;
                            data.Handphone = detail.Handphone;
                            data.Email = detail.Email;
                            data.IsActive = false;
                        }
                    }

                    var json = JsonConvert.SerializeObject(data);
                    var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.PostAsync(baseUrl + "/api/SupplierApi", httpData))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }


                return View(data);
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
            return RedirectToAction("Index");
        }
    }
}
