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
    public class GetProvinceQuery : IRequest<List<string>>
    {
        public class GetProvinceQueryHandler : IRequestHandler<GetProvinceQuery, List<string>>
        {
            private readonly IApplicationDbContext _context;

            public GetProvinceQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
            }

            public async Task<List<string>> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.AddressInfos
                    .Select(o => o.Province)
                    .Distinct()
                    .ToListAsync(cancellationToken);

                vm.Sort();
                vm.RemoveAll(string.IsNullOrWhiteSpace);

                return vm;
            }
        }
    }
}
