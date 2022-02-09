using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UMApplication.Application.AddressInfos.Queries
{
    public class GetDistrictQuery : IRequest<List<string>>
    {

        public string Province { get; set; }
        public class GetDistrictQueryHandler : IRequestHandler<GetDistrictQuery, List<string>>
        {
            private readonly IApplicationDbContext _context;

            public GetDistrictQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
            }

            public async Task<List<string>> Handle(GetDistrictQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.AddressInfos
                    .Where(o => o.Province == request.Province)
                    .Select(o => o.District)
                    .Distinct()
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
