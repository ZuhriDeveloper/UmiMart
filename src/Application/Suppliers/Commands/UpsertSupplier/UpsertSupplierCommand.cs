using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.Suppliers.Commands.UpsertSupplier
{
    public class UpsertSupplierCommand : IRequest<int>
    {
        public int? Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string ContactPerson { get; set; }
        public string Telepon { get; set; }
        public string Handphone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
