using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.Vouchers.Queries.GetVoucherList
{
    public class GetVoucherListQuery : IRequest<VoucherListVm>
    {
      public class GetVoucherListQueryHandler : IRequestHandler<GetVoucherListQuery,VoucherListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetVoucherListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VoucherListVm> Handle(GetVoucherListQuery request, CancellationToken cancellationToken)
            {
                var vouchers = await _context.Vouchers
                   .ProjectTo<VoucherDto>(_mapper.ConfigurationProvider)
                   .OrderBy(e => e.VoucherCode)
                   .ToListAsync(cancellationToken);

                var vm = new VoucherListVm
                {
                    Vouchers = vouchers
                };

                return vm;
            }
        }
    }
}
