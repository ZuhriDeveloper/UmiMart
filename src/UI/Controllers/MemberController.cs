using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.Members.Queries.GetMembersList;
using UMApplication.Application.Members.Queries.GetMemberDetail;
using UMApplication.Application.Members.Commands.UpSertMember;
using System.Text;

namespace UMApplication.UI.Controllers
{
    public class MemberController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            MembersListVm memberList = new MembersListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/MemberApi"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    memberList = JsonConvert.DeserializeObject<MembersListVm>(apiResponse);
                }
            }
            return View(memberList.Members);
        }

        //[Authorize(Roles = "Admin")]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(int id)
        {
            UpSertMemberCommand data = new UpSertMemberCommand();

            if (id != 0)
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(baseUrl + "/api/MemberApi/" + id.ToString()))
                    {
                        MemberDetailVm detail;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        detail = JsonConvert.DeserializeObject<MemberDetailVm>(apiResponse);

                        data.Id = detail.Id;
                        data.FullName = detail.FullName;
                        data.MembershipNumber = detail.MembershipNumber;
                        data.CardNumber = detail.CardNumber;
                        data.Address = detail.Address;
                        data.Plafon = detail.Plafon;
                        data.DiscountRate = detail.DiscountRate;
                        data.DiscountFlat = detail.DiscountFlat;
                        data.IsActive = true;
                    }
                }
            }


            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(UpSertMemberCommand data)
        {
            try
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                data.IsActive = true;
                var json = JsonConvert.SerializeObject(data);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/MemberApi", httpData))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            if (data.Id == 0)
                                TempData["Message"] = "Member berhasil ditambahkan";
                            else
                                TempData["Message"] = "Member berhasil diupdate";

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
            return RedirectToAction("Create", data.Id);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            try
            {
                UpSertMemberCommand data = new UpSertMemberCommand();

                if (id != 0)
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.GetAsync(baseUrl + "/api/MemberApi/" + id.ToString()))
                        {
                            MemberDetailVm detail;
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            detail = JsonConvert.DeserializeObject<MemberDetailVm>(apiResponse);

                            data.Id = detail.Id;
                            data.FullName = detail.FullName;
                            data.MembershipNumber = detail.MembershipNumber;
                            data.CardNumber = detail.CardNumber;
                            data.Address = detail.Address;
                            data.Plafon = detail.Plafon;
                            data.DiscountRate = detail.DiscountRate;
                            data.IsActive = false;
                        }
                    }

                    var json = JsonConvert.SerializeObject(data);
                    var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.PostAsync(baseUrl + "/api/MemberApi", httpData))
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
