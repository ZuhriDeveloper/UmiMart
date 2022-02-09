using MediatR;
using System;

namespace UMApplication.Application.SalesOrderItems.Commands.InsertSalesOrderItem
{
   public class InsertSalesOrderItemCommand : IRequest
    {
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
