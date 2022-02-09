using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using UMApplication.Application.Vouchers.Queries;
using System.Threading.Tasks;

namespace UMApplication.Application.Vouchers.Queries.GetVoucherDetail
{
    public class GetVoucherDetailQuery : IRequest<VoucherDto>
    {
        public int Id { get; set; }

        public class GetVoucherDetailQueryHandler : IRequestHandler<GetVoucherDetailQuery, VoucherDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetVoucherDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<VoucherDto> Handle(GetVoucherDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Vouchers
                    .Where(e => e.VoucherId == request.Id)
                    .ProjectTo<VoucherDto>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}
