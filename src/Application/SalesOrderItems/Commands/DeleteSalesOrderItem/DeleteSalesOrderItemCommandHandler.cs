using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UMApplication.Application.SalesOrderItems.Commands.DeleteSalesOrderItem
{
    public class DeleteSalesOrderItemCommandHandler : IRequestHandler<DeleteSalesOrderItemCommand>
    {

        private readonly IApplicationDbContext _context;

        public DeleteSalesOrderItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteSalesOrderItemCommand request, CancellationToken cancellationToken)
        {
            var listToRemove = await _context.SalesOrderItems
                                .Where(x => x.SalesOrderId == request.SalesOrderId).ToListAsync(cancellationToken);

            _context.SalesOrderItems.RemoveRange(listToRemove);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
