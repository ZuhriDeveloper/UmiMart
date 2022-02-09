using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.Products.Queries;
using UMApplication.Application.Products.Queries.GetProductList;
using UMApplication.Application.Products.Queries.GetProductDetail;
using UMApplication.Application.Products.Commands.UpsertProduct;
using System.Text;
using UMApplication.Domain.Common;

namespace UMApplication.UI.Controllers
{
    public class ProductController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            ProductListVm productList = new ProductListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/ProductApi/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    productList = JsonConvert.DeserializeObject<ProductListVm>(apiResponse);
                }
            }
            return View(productList.Products);
        }

        public async Task<IActionResult> GetEmployeeList(JqueryDatatableParam param)
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            ProductListVm productList = new ProductListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/ProductApi/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    productList = JsonConvert.DeserializeObject<ProductListVm>(apiResponse);
                }
            }

            var productDtoList = productList.Products.ToList();

            if (!string.IsNullOrEmpty(param.sSearch))
            {
                productDtoList = productList.Products.Where(x => x.PLU.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Deskripsi.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Barcode.ToString().ToLower().Contains(param.sSearch.ToLower())
                                              || x.Hpp.ToString().Contains(param.sSearch.ToLower())
                                              || x.Ppn.ToString().Contains(param.sSearch.ToLower())
                                              || x.Margin.ToString().Contains(param.sSearch.ToLower())
                                              || x.HargaJual.ToString().Contains(param.sSearch.ToLower())).ToList();

            }

            var displayResult = productDtoList.Skip(param.iDisplayStart)
               .Take(param.iDisplayLength).ToList();
            var totalRecords = productDtoList.Count();


            return Json(new
            {
                param.sEcho,
                iTotalRecords = totalRecords,
                iTotalDisplayRecords = totalRecords,
                aaData = displayResult
            });

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(int id)
        {
            UpsertProductCommand data = new UpsertProductCommand();

            if (id != 0)
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(baseUrl + "/api/ProductApi/" + id.ToString()))
                    {
                        ProductDto detail;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        detail = JsonConvert.DeserializeObject<ProductDto>(apiResponse);

                        data.Id = detail.Id;
                        data.Deskripsi = detail.Deskripsi;
                        //data.PLU = detail.PLU;
                        data.Barcode = detail.Barcode;
                        data.HargaJual = Convert.ToDecimal(detail.HargaJual);
                        data.Hpp = Convert.ToDecimal(detail.Hpp);
                        data.Ppn = detail.Ppn;
                        data.Margin = Convert.ToDecimal(detail.Margin);
                        data.IsActive = true;
                    }
                }
            }


            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(UpsertProductCommand data)
        {
            TempData["Message"] = "";
            try
            {
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                data.IsActive = true;
                var json = JsonConvert.SerializeObject(data);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/ProductApi", httpData))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            if (data.Id == 0)
                                TempData["Message"] = "Produk berhasil ditambahkan";
                            else
                                TempData["Message"] = "Produk berhasil diubah";

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
        [HttpPost]
        public async Task<ActionResult> Index(IFormCollection formCollection)
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            var listId = formCollection["ID"];
            foreach (var id in listId)
            {
                UpsertProductCommand data = new UpsertProductCommand();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(baseUrl + "/api/ProductApi/" + id.ToString()))
                    {
                        ProductDto detail;
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        detail = JsonConvert.DeserializeObject<ProductDto>(apiResponse);


                        data.Id = detail.Id;
                        data.Deskripsi = detail.Deskripsi;
                        //data.PLU = detail.PLU;
                        data.Barcode = detail.Barcode;
                        data.HargaJual = Convert.ToDecimal(detail.HargaJual);
                        data.Hpp = Convert.ToDecimal(detail.Hpp);
                        data.Ppn = detail.Ppn;
                        data.Margin = Convert.ToDecimal(detail.Margin);
                        data.IsActive = false;
                    }
                }

                var json = JsonConvert.SerializeObject(data);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/ProductApi", httpData))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception();
                        }
                    }
                }

            }

            return RedirectToAction("Index");

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            try
            {
                UpsertProductCommand data = new UpsertProductCommand();

                if (id != 0)
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.GetAsync(baseUrl + "/api/ProductApi/" + id.ToString()))
                        {
                            ProductDto detail;
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            detail = JsonConvert.DeserializeObject<ProductDto>(apiResponse);


                            data.Id = detail.Id;
                            data.Deskripsi = detail.Deskripsi;
                            //data.PLU = detail.PLU;
                            data.Barcode = detail.Barcode;
                            data.HargaJual = Convert.ToDecimal(detail.HargaJual);
                            data.Hpp = Convert.ToDecimal(detail.Hpp);
                            data.Ppn = detail.Ppn;
                            data.Margin = Convert.ToDecimal(detail.Margin);
                            data.IsActive = false;
                        }
                    }

                    var json = JsonConvert.SerializeObject(data);
                    var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.PostAsync(baseUrl + "/api/ProductApi", httpData))
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
