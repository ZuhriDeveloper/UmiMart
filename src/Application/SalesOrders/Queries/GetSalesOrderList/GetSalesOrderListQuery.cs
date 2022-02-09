using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.SalesOrders.Queries.GetSalesOrderList
{
    public class GetSalesOrdersListQuery : IRequest<SalesOrderListVm>
    {
        public class GetSalesOrdersListQueryHandler : IRequestHandler<GetSalesOrdersListQuery, SalesOrderListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetSalesOrdersListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SalesOrderListVm> Handle(GetSalesOrdersListQuery request, CancellationToken cancellationToken)
            {
                var SalesOrders = await _context.SalesOrders
                   .ProjectTo<SalesOrderDto>(_mapper.ConfigurationProvider)
                   .OrderBy(e => e.TanggalPesan)
                   .ToListAsync(cancellationToken);

                var vm = new SalesOrderListVm
                {
                    SalesOrders = SalesOrders
                };

                return vm;
            }
        }
    }
}
