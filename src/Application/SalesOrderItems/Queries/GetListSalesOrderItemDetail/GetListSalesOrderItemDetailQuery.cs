using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.SalesOrderItems.Queries.GetListSalesOrderItemDetail
{
   public class GetListSalesOrderItemDetailQuery : IRequest<SalesOrderItemListVm>
    {
        public int SalesOrderId { get; set; }

        public class GetListSalesOrderItemDetailQueryHandler : IRequestHandler<GetListSalesOrderItemDetailQuery, SalesOrderItemListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetListSalesOrderItemDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<SalesOrderItemListVm> Handle(GetListSalesOrderItemDetailQuery request, CancellationToken cancellationToken)
            {
                var SalesOrderItems = await _context.SalesOrderItems
                    .Where(x => x.SalesOrderId == request.SalesOrderId)
                    .ProjectTo<SalesOrderItemDto>(_mapper.ConfigurationProvider)
                    .OrderBy(e => e.Product.Name)
                    .ToListAsync(cancellationToken);

                var vm = new SalesOrderItemListVm
                {
                    Items = SalesOrderItems
                };

                return vm;
            }
        }

    }
}
