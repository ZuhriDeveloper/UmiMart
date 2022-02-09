using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.AddressInfos.Queries
{
   public class GetAddressInfoDetailQuery : IRequest<AddressInfoDetailVm>
    {
        public string Village { get; set; }

        public string PostalCode { get; set; }

        public class GetAddressInfoDetailQueryHandler : IRequestHandler<GetAddressInfoDetailQuery, AddressInfoDetailVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAddressInfoDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<AddressInfoDetailVm> Handle(GetAddressInfoDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.AddressInfos
                    .Where(e => e.Village == request.Village && e.PostalCode == request.PostalCode)
                    .ProjectTo<AddressInfoDetailVm>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }

    }
}
