using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using System;

namespace UMApplication.Application.Products.Commands.UpsertProduct
{
    public class UpsertProductCommandHandler : IRequestHandler<UpsertProductCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpsertProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpsertProductCommand request, CancellationToken cancellationToken)
        {

            Product entity;

            if (request.Id.HasValue && request.Id > 0)
            {
                entity = await _context.Products.FindAsync(request.Id.Value);
            }
            else
            {
                string lastPLU = _context.Products.Max(p => p.Code);
                long intPLU = 0;

                try
                {
                    intPLU = Convert.ToInt64(lastPLU) + 1;
                }
                catch (Exception ex)
                {
                    intPLU = 0;
                }
                entity = new Product();
                entity.Code = intPLU.ToString();
                _context.Products.Add(entity);
            }
            entity.Name = request.Deskripsi;
            entity.Barcode = request.Barcode;
            if (string.IsNullOrEmpty(entity.Barcode))
                request.Barcode = entity.Code;
            entity.IsActive = request.IsActive;
            entity.Hpp = request.Hpp;
            entity.Ppn = request.Ppn;
            entity.Margin = request.Margin;
            entity.SellPrice = request.HargaJual;

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProductId;
        }
    }
}
