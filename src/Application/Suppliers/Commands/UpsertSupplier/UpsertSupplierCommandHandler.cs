using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;

namespace UMApplication.Application.Suppliers.Commands.UpsertSupplier
{
    public class UpsertSupplierCommandHandler : IRequestHandler<UpsertSupplierCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpsertSupplierCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpsertSupplierCommand request, CancellationToken cancellationToken)
        {

            Supplier entity;

            if (request.Id.HasValue && request.Id > 0)
            {
                entity = await _context.Suppliers.FindAsync(request.Id.Value);
            }
            else
            {
                entity = new Supplier();
                _context.Suppliers.Add(entity);
            }

            entity.Name = request.Nama;
            entity.Address = request.Alamat;
            entity.ContactPerson = request.ContactPerson;
            entity.IsActive = request.IsActive;
            entity.Phone = request.Telepon;
            entity.Handphone = request.Handphone;
            entity.Email = request.Email;

            await _context.SaveChangesAsync(cancellationToken);

            return entity.SupplierId;
        }
    }
}
