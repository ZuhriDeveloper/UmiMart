using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UMApplication.Application.V_SalesSummaryPerItem.Queries;
using UMApplication.Application.V_SalesSummaryPerItem.Queries.GetSalesSummaryListPerItem;

using System.Text;
using UMApplication.Domain.Common;

namespace UMApplication.UI.Controllers
{
    public class SalesSummaryPerItemController : Controller
    {
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
