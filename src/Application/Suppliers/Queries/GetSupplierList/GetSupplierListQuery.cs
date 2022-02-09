using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace UMApplication.Application.Suppliers.Queries.GetSupplierList
{
    public class GetSuppliersListQuery : IRequest<SupplierListVm>
    {
        public class GetSuppliersListQueryHandler : IRequestHandler<GetSuppliersListQuery, SupplierListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSuppliersListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SupplierListVm> Handle(GetSuppliersListQuery request, CancellationToken cancellationToken)
            {
                var Suppliers = await _context.Suppliers
                   .ProjectTo<SupplierDto>(_mapper.ConfigurationProvider)
                   .OrderBy(e => e.Nama)
                   .ToListAsync(cancellationToken);

                var vm = new SupplierListVm
                {
                    Suppliers = Suppliers
                };

                return vm;
            }
        }
    }
}
