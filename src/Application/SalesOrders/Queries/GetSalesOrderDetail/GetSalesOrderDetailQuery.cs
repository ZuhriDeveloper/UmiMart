using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using UMApplication.Application.SalesOrders.Queries;
using System.Threading.Tasks;

namespace UMApplication.Application.SalesOrders.Queries.GetSalesOrderDetail
{
   public class GetSalesOrderDetailQuery : IRequest<SalesOrderDto>
    {
        public int Id { get; set; }


        public class GetSalesOrderDetailQueryHandler : IRequestHandler<GetSalesOrderDetailQuery, SalesOrderDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetSalesOrderDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<SalesOrderDto> Handle(GetSalesOrderDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.SalesOrders
                   .Where(e => e.SalesOrderId == request.Id)
                   .ProjectTo<SalesOrderDto>(_mapper.ConfigurationProvider)
                   .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }

    }
}
