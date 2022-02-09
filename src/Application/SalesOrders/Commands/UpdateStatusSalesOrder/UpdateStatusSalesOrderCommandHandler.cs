using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using UMApplication.Application.Common.Exceptions;
using System;

namespace UMApplication.Application.SalesOrders.Commands.UpdateStatusSalesOrder
{
   public class UpdateStatusSalesOrderCommandHandler : IRequestHandler<UpdateStatusSalesOrderCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateStatusSalesOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStatusSalesOrderCommand request, CancellationToken cancellationToken)
        {
            SalesOrder SO = await _context.SalesOrders.FindAsync(request.SalesOrderId);

            if (SO == null)
                throw new NotFoundException("Pemesanan Barang Tidak Ditemukan");

            SO.Status = request.NewStatus;
            SO.LastModified = DateTime.Now;

            if(request.PaidDate != null)
            {
                SO.PaidDate = request.PaidDate ?? DateTime.Now;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
