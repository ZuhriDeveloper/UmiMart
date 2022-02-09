using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using UMApplication.Application.Suppliers.Queries;
using System.Threading.Tasks;

namespace UMApplication.Application.Suppliers.Queries.GetSupplierDetail
{
    public class GetSupplierDetailQuery : IRequest<SupplierDto>
    {
        public int Id { get; set; }

        public class GetSupplierDetailQueryHandler : IRequestHandler<GetSupplierDetailQuery, SupplierDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSupplierDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SupplierDto> Handle(GetSupplierDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Suppliers
                    .Where(e => e.SupplierId == request.Id)
                    .ProjectTo<SupplierDto>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}
