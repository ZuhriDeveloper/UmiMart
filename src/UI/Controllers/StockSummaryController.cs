using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.V_StockSummary.Queries;
using System.Linq;
using System.Globalization;

namespace UMApplication.UI.Controllers
{
    public class StockSummaryController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            StockSummaryListVm list = new StockSummaryListVm();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(baseUrl + "/api/StockSummaryApi"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<StockSummaryListVm>(apiResponse);
                }
            }
            var totalStock = 0;
            decimal grandTotal = 0;
            foreach (StockSummaryDto data in list.StockSUmmaries)
            {
                totalStock += data.Quantity;
                grandTotal += data.Total;
            }

            ViewBag.TotalStock = totalStock;
            ViewBag.GrandTotal = grandTotal.ToString("N0", CultureInfo.CurrentCulture);

            return View(list.StockSUmmaries);
        }
    }
}
