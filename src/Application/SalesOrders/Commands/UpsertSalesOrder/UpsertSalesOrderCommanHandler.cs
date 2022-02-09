using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using UMApplication.Application.Common.Exceptions;
using System.Linq;

namespace UMApplication.Application.SalesOrders.Commands.UpsertSalesOrder
{
    public class UpsertSalesOrderCommandHandler : IRequestHandler<UpsertSalesOrderCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpsertSalesOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpsertSalesOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                SalesOrder entity;

                if(request.SalesOrderId == 0)
                {
                    entity = new SalesOrder();
                    _context.SalesOrders.Add(entity);
                }
                else
                {
                    entity = _context.SalesOrders.Where(x => x.SalesOrderId == request.SalesOrderId).FirstOrDefault();
                }

                entity.SalesOrderNumber = request.SalesOrderNumber;
                entity.SalesOrderDate = request.SalesOrderDate;
                entity.SalesOrderDueDate = request.SalesOrderDueDate;
                entity.SupplierId = request.SupplierId;
                entity.GrandTotal = request.GrandTotal;
                entity.PaidDate = request.PaidDate;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.SalesOrderId;
            }
            catch (global::System.Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
           
        }
    }
}
