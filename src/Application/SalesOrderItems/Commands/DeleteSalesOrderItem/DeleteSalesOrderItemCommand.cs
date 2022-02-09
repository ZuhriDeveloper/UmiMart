using MediatR;


namespace UMApplication.Application.SalesOrderItems.Commands.DeleteSalesOrderItem
{
    public class DeleteSalesOrderItemCommand : IRequest
    {
        public int SalesOrderId { get; set; }
    }
}
