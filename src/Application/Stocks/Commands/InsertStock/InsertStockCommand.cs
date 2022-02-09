using MediatR;
using System;

namespace UMApplication.Application.Stocks.Commands.InsertStock
{
    public class InsertStockCommand : IRequest<int>
    {
        public int ProductId { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public DateTime InputDate { get; set; }

    }
}
