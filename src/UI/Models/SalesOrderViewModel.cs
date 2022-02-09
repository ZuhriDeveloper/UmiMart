using System;
using System.Collections.Generic;
using UMApplication.Application.SalesOrderItems.Commands.InsertSalesOrderItem;

namespace UMApplication.UI.Models
{
    public class SalesOrderViewModel
    {

        public SalesOrderViewModel()
        {
            SalesOrderId = 0;
            Items = new List<SalesOrderItemViewModel>();
            SalesOrderDate = DateTime.Now;
            SalesOrderDueDate = DateTime.Now.AddMonths(1);
        }

        public int SalesOrderId { get; set; }
        public string SalesOrderNumber { get; set; }

        public DateTime SalesOrderDate { get; set; }

        public DateTime SalesOrderDueDate { get; set; }

        public int SupplierId { get; set; }

        public decimal GrandTotal { get; set; }

        public List<SalesOrderItemViewModel> Items { get; set; }
    }

    public class SalesOrderItemViewModel
    {
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }
    }
}
