using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.Products.Commands.UpsertProduct
{
   public class UpsertProductCommand : IRequest<int>
    {
        public int? Id { get; set; }
        //public string PLU { get; set; }
        public string Deskripsi { get; set; }
        public string Barcode { get; set; }
        public decimal Hpp { get; set; }
        public float Ppn { get; set; }
        public decimal Margin { get; set; }
        public decimal HargaJual { get; set; }
        public bool IsActive { get; set; }
    }
}
