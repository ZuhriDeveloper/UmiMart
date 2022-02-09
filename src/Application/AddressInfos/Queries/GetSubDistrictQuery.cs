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
   public class GetSubDistrictQuery : IRequest<List<string>>
    {
        public string Province { get; set; }
        public string District { get; set; }
        public class GetSubDistrictQueryHandler : IRequestHandler<GetSubDistrictQuery, List<string>>
        {
            private readonly IApplicationDbContext _context;

            public GetSubDistrictQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
            }

            public async Task<List<string>> Handle(GetSubDistrictQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.AddressInfos
                    .Where(o => o.Province == request.Province && o.District == request.District)
                    .Select(o => o.SubDistrict)
                    .Distinct()
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
