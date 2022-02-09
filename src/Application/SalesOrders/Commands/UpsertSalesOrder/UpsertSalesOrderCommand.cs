using MediatR;
using System;

namespace UMApplication.Application.SalesOrders.Commands.UpsertSalesOrder
{
   public class UpsertSalesOrderCommand : IRequest<int>
    {
        public UpsertSalesOrderCommand()
        {
            PaidDate = new DateTime(1900, 1, 1);
        }
        public int SalesOrderId { get; set; }
        public string SalesOrderNumber { get; set; }

        public DateTime SalesOrderDate { get; set; }

        public DateTime SalesOrderDueDate { get; set; }

        public DateTime PaidDate { get; set; }

        public int SupplierId { get; set; }

        public string Status { get; set; }

        public decimal GrandTotal { get; set; }
    }
}
