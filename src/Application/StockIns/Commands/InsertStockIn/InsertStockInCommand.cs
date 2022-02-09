using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.StockIns.Commands.InsertStockIn
{
    public class InsertStockInCommand : IRequest<int>
    {
        public int ProductId { get; set; }

        public string StockInCode { get; set; }

        public int SupplierId { get; set; }
        public int Quantity { get; set; }

        public DateTime InputDate { get; set; }

    }
}
