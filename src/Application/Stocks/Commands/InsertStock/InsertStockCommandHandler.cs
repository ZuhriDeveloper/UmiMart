using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;

namespace UMApplication.Application.Stocks.Commands.InsertStock
{
    public class InsertStockCommandHandler : IRequestHandler<InsertStockCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public InsertStockCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(InsertStockCommand request, CancellationToken cancellationToken)
        {

            Stock entity;

            entity = new Stock();
            _context.Stocks.Add(entity);
            entity.ProductId = request.ProductId;
            entity.Quantity = request.Quantity;
            entity.InputDate = request.InputDate;

            await _context.SaveChangesAsync(cancellationToken);

            return entity.StockId;
        }
    }
}
