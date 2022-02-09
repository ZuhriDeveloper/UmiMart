using MediatR;
using System;

namespace UMApplication.Application.SalesOrders.Commands.UpdateStatusSalesOrder
{
    public class UpdateStatusSalesOrderCommand : IRequest
    {
        public int SalesOrderId { get; set; }
        public string NewStatus { get; set; }
        public DateTime? PaidDate { get; set; }
    }
}
