using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.V_StockSummary.Queries
{
    public class GetStockSummaryListQuery : IRequest<StockSummaryListVm>
    {
        public class GetStockSummaryListQueryHandler : IRequestHandler<GetStockSummaryListQuery, StockSummaryListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetStockSummaryListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<StockSummaryListVm> Handle(GetStockSummaryListQuery request, CancellationToken cancellationToken)
            {
                var list = await _context.V_StockSummaries
                    .ProjectTo<StockSummaryDto>(_mapper.ConfigurationProvider)
                    .OrderBy(x => x.ProductName)
                    .ToListAsync(cancellationToken);

                var vm = new StockSummaryListVm
                {
                    StockSUmmaries = list
                };

                return vm;
            }
        }
    }
}
