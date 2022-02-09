using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.SalesOrders.Queries;
using UMApplication.Application.SalesOrders.Queries.GetSalesOrderList;
using UMApplication.Application.SalesOrders.Commands.UpsertSalesOrder;
using UMApplication.Application.SalesOrderItems.Commands.InsertSalesOrderItem;
using UMApplication.Application.SalesOrders.Commands.UpdateStatusSalesOrder;
using UMApplication.Application.SalesOrderItems.Queries;
using UMApplication.Application.SalesOrderItems.Queries.GetListSalesOrderItemDetail;
using System.Text;
using UMApplication.UI.Models;
using System.Net;
using UMApplication.Application.SalesOrderItems.Commands.DeleteSalesOrderItem;

namespace UMApplication.UI.Controllers
{
    public class SalesOrderController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            SalesOrderListVm SalesOrderList = new SalesOrderListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/SalesOrderApi"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    SalesOrderList = JsonConvert.DeserializeObject<SalesOrderListVm>(apiResponse);
                }
            }
            return View(SalesOrderList.SalesOrders);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var data = new SalesOrderViewModel();
            return View(data);
        }

        public async Task<IActionResult> Edit(int id)
        {

            SalesOrderDto headerData = await GetHeaderDataAsync(id);
            SalesOrderItemListVm itemData = await GetItemDataAsync(id);
            SalesOrderViewModel viewData = MappingHeaderDataToView(headerData, itemData);

            return View("Create", viewData);
        }

        public async Task<IActionResult> Detail(int id)
        {

            SalesOrderDto headerData = await GetHeaderDataAsync(id);
            SalesOrderItemListVm itemData = await GetItemDataAsync(id);
            SalesOrderViewModel viewData = MappingHeaderDataToView(headerData, itemData);

            return View("Detail", viewData);
        }

        private async Task<SalesOrderItemListVm> GetItemDataAsync(int id)
        {
            SalesOrderItemListVm result = new SalesOrderItemListVm();
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/SalesOrderApi/GetListItems/" + id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<SalesOrderItemListVm>(apiResponse);
                }
            }

            return result;
        }

        private SalesOrderViewModel MappingHeaderDataToView(SalesOrderDto data, SalesOrderItemListVm itemData)
        {
            SalesOrderViewModel view = new SalesOrderViewModel();
            view.SalesOrderId = data.Id;
            view.SalesOrderNumber = data.NomorSalesOrder;
            view.SalesOrderDate = data.TanggalPesan;
            view.SalesOrderDueDate = data.TanggalJatuhTempo;
            view.SupplierId = data.SupplierId;
            view.GrandTotal = data.GrandTotal;

            view.Items = new List<SalesOrderItemViewModel>(0);

            foreach (var soItem in itemData.Items)
            {
                var item = new SalesOrderItemViewModel();
                item.ProductId = soItem.ProductId;
                item.ProductName = soItem.Product.Name;
                item.Quantity = soItem.Quantity;
                item.UnitPrice = soItem.UnitPrice;

                view.Items.Add(item);
            }

            return view;
        }

        private async Task<SalesOrderDto> GetHeaderDataAsync(int id)
        {
            SalesOrderDto result = new SalesOrderDto();
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/SalesOrderApi/" + id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<SalesOrderDto>(apiResponse);
                }
            }

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> SaveSOAsync([FromBody] SalesOrderViewModel param)
        {
            try
            {

                var SoId = await SaveHeaderAsync(param);

                if (param.SalesOrderId != 0)
                {
                    await DeleteItemAsync(param.SalesOrderId);
                }

                await SaveItemAsync(param.Items, SoId);
                TempData["Message"] = "Data Berhasil disimpan";

                //return RedirectToAction("Index");

                return Json(true);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(ex.Message);
            }


        }

        private async Task DeleteItemAsync(int salesOrderId)
        {
            var command = new DeleteSalesOrderItemCommand();
            command.SalesOrderId = salesOrderId;
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            var json = JsonConvert.SerializeObject(command);
            var httpData = new StringContent(json, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderApi/DeleteItem", httpData))
                {
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }

        private async Task SaveItemAsync(List<SalesOrderItemViewModel> items, string soId)
        {
            foreach (SalesOrderItemViewModel soItem in items)
            {
                InsertSalesOrderItemCommand itemData = new InsertSalesOrderItemCommand();
                itemData.ProductId = soItem.ProductId;
                itemData.Quantity = soItem.Quantity;
                itemData.SalesOrderId = Convert.ToInt32(soId);
                itemData.UnitPrice = soItem.UnitPrice;
                string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                var json = JsonConvert.SerializeObject(itemData);
                var httpData = new StringContent(json, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderItemApi", httpData))
                    {
                        if (response.IsSuccessStatusCode)
                        {

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
        }


        private async Task<string> SaveHeaderAsync(SalesOrderViewModel data)
        {
            var header = new UpsertSalesOrderCommand();
            header.SalesOrderId = data.SalesOrderId;
            header.SalesOrderDate = data.SalesOrderDate;
            header.SalesOrderDueDate = data.SalesOrderDueDate;
            header.SalesOrderNumber = data.SalesOrderNumber;
            header.SupplierId = data.SupplierId;
            header.GrandTotal = data.Items.Select(x => x.Quantity * x.UnitPrice).Sum();

            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            var json = JsonConvert.SerializeObject(header);
            var httpData = new StringContent(json, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderApi", httpData))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }
        public async Task<IActionResult> Approve(int id)
        {
            var entity = new UpdateStatusSalesOrderCommand();
            entity.SalesOrderId = id;
            entity.NewStatus = "DISETUJUI";
            await UpdateStatusSOAsync(entity);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Paid([FromBody] PembayaranSOModel data)
        {
            var entity = new UpdateStatusSalesOrderCommand();
            entity.SalesOrderId = data.SoId;
            entity.PaidDate = data.PaidDate.AddDays(1); //fuckin javascriptdate
            entity.NewStatus = "DIBAYAR";
            await UpdateStatusSOAsync(entity);
            return Json(true);
        }
        public async Task<IActionResult> Reject(int id)
        {
            var entity = new UpdateStatusSalesOrderCommand();
            entity.SalesOrderId = id;
            entity.NewStatus = "DITOLAK";
            await UpdateStatusSOAsync(entity);
            return RedirectToAction("Index");
        }

        private async Task<IActionResult> UpdateStatusSOAsync(UpdateStatusSalesOrderCommand entity)
        {
            //var entity = new UpdateStatusSalesOrderCommand();
            //entity.SalesOrderId = id;
            //entity.NewStatus = status.ToUpper();
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            var json = JsonConvert.SerializeObject(entity);
            var httpData = new StringContent(json, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderApi/EditStatus", httpData))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return Ok();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }


        //[Authorize(Roles = "Admin")]
        //[HttpPost]
        //public async Task<IActionResult> Create(UpsertSalesOrderCommand data)
        //{
        //    try
        //    {
        //        string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
        //        data.IsActive = true;
        //        var json = JsonConvert.SerializeObject(data);
        //        var httpData = new StringContent(json, Encoding.UTF8, "application/json");

        //        using (var httpClient = new HttpClient())
        //        {
        //            using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderApi", httpData))
        //            {
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    return RedirectToAction("Index");
        //                }
        //                else
        //                {
        //                    throw new Exception();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        foreach (var modelState in ModelState.Values)
        //        {
        //            foreach (var error in modelState.Errors)
        //            {
        //                sb.Append(error.ErrorMessage);
        //            }
        //        }

        //        TempData["Error"] = sb.ToString();
        //    }
        //    return RedirectToAction("Index");
        //}

        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
        //    try
        //    {
        //        UpsertSalesOrderCommand data = new UpsertSalesOrderCommand();

        //        if (id != 0)
        //        {
        //            using (var httpClient = new HttpClient())
        //            {
        //                using (var response = await httpClient.GetAsync(baseUrl + "/api/SalesOrderApi/" + id.ToString()))
        //                {
        //                    SalesOrderDto detail;
        //                    string apiResponse = await response.Content.ReadAsStringAsync();
        //                    detail = JsonConvert.DeserializeObject<SalesOrderDto>(apiResponse);


        //                    data.Id = detail.Id;
        //                    data.Deskripsi = detail.Deskripsi;
        //                    data.PLU = detail.PLU;
        //                    data.Barcode = detail.Barcode;
        //                    data.HargaJual = detail.HargaJual;
        //                    data.HppPpn = detail.HppPpn;
        //                    data.IsActive = false;
        //                }
        //            }

        //            var json = JsonConvert.SerializeObject(data);
        //            var httpData = new StringContent(json, Encoding.UTF8, "application/json");

        //            using (var httpClient = new HttpClient())
        //            {
        //                using (var response = await httpClient.PostAsync(baseUrl + "/api/SalesOrderApi", httpData))
        //                {
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        return RedirectToAction("Index");
        //                    }
        //                    else
        //                    {
        //                        throw new Exception();
        //                    }
        //                }
        //            }
        //        }


        //        return View(data);
        //    }
        //    catch (Exception ex)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        foreach (var modelState in ModelState.Values)
        //        {
        //            foreach (var error in modelState.Errors)
        //            {
        //                sb.Append(error.ErrorMessage);
        //            }
        //        }

        //        TempData["Error"] = sb.ToString();
        //    }
        //    return RedirectToAction("Index");
        //}

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PembayaranSo()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            SalesOrderListVm SalesOrderList = new SalesOrderListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/SalesOrderApi"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    SalesOrderList = JsonConvert.DeserializeObject<SalesOrderListVm>(apiResponse);
                }
            }
            return View(SalesOrderList.SalesOrders.Where(x => x.Status == "DISETUJUI").ToList());
        }
    }
}
