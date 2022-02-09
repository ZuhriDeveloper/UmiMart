using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using UMApplication.Application.Common.Exceptions;
using System.Linq;
using System;

namespace UMApplication.Application.Vouchers.Commands.UpsertVoucher
{
    public class UpsertVoucherCommandHandler : IRequestHandler<UpsertVoucherCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public UpsertVoucherCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(UpsertVoucherCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Voucher entity;

                if (request.VoucherId == 0)
                {
                    entity = new Voucher();
                    _context.Vouchers.Add(entity);
                }
                else
                {
                    entity = _context.Vouchers.Where(x => x.VoucherId == request.VoucherId).FirstOrDefault();
                }

                entity.VoucherCode = request.VoucherCode;
                entity.Status = request.Status;
                entity.No_Faktur = request.No_Faktur;
                entity.Nominal = request.Nominal;
                entity.ValidFrom = request.ValidFrom;
                entity.ValidTo = request.ValidTo;
                entity.UsageDate = request.UsageDate;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.VoucherId;
            }
            catch (global::System.Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
