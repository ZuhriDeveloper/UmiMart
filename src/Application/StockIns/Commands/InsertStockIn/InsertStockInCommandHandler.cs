using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using UMApplication.Application.Stocks.Commands.InsertStock;

namespace UMApplication.Application.StockIns.Commands.InsertStockIn
{
    public class InsertStockInCommandHandler : IRequestHandler<InsertStockInCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMediator _mediator;

        public InsertStockInCommandHandler(IApplicationDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<int> Handle(InsertStockInCommand request, CancellationToken cancellationToken)
        {

            StockIn entity;

            entity = new StockIn();
            _context.StockIns.Add(entity);

            entity.StockInCode = request.StockInCode;
            entity.ProductId = request.ProductId;
            entity.SupplierId = request.SupplierId;
            entity.Quantity = request.Quantity;
            entity.InputDate = request.InputDate;

            await _context.SaveChangesAsync(cancellationToken);

            InsertStockCommand stock = new InsertStockCommand();
            stock.ProductId = request.ProductId;
            stock.Quantity = request.Quantity;
            stock.InputDate = request.InputDate;
            stock.Status = "IN";

            await _mediator.Send(stock,cancellationToken);


            return entity.StockInId;
        }
    }
}
