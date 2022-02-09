using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;

namespace UMApplication.Application.SalesOrderItems.Commands.InsertSalesOrderItem
{
    public class InsertSalesOrderItemCommandHandler : IRequestHandler<InsertSalesOrderItemCommand>
    {
        private readonly IApplicationDbContext _context;

        public InsertSalesOrderItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(InsertSalesOrderItemCommand request, CancellationToken cancellationToken)
        {

            SalesOrderItem entity;

            entity = new SalesOrderItem();
            _context.SalesOrderItems.Add(entity);
            entity.SalesOrderId = request.SalesOrderId;
            entity.ProductId = request.ProductId;
            entity.UnitPrice = request.UnitPrice;
            entity.Quantity = request.Quantity;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
