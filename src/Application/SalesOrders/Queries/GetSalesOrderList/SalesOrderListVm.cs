using System.Collections.Generic;

namespace UMApplication.Application.SalesOrders.Queries.GetSalesOrderList
{
    public class SalesOrderListVm
    {
        public IList<SalesOrderDto> SalesOrders { get; set; }
    }
}
