using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.V_SalesSummary.Queries.GetSalesSummaryListByDate
{
    public class GetSalesSummaryListByDateQuery : IRequest<SalesSummaryListVm>
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public class GetSalesSummaryListByDateQueryHandler : IRequestHandler<GetSalesSummaryListByDateQuery,SalesSummaryListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetSalesSummaryListByDateQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SalesSummaryListVm> Handle (GetSalesSummaryListByDateQuery request,CancellationToken cancellationToken)
            {
                var list = await _context.V_SalesSummaries
                    .Where(x => x.Tgl_Transaksi >= request.DateFrom && x.Tgl_Transaksi <= request.DateTo)
                    .ProjectTo<SalesSummaryDto>(_mapper.ConfigurationProvider)
                    .OrderBy(x => x.Tgl_Transaksi).ThenBy(x => x.No_Faktur)
                    .ToListAsync(cancellationToken);

                var vm = new SalesSummaryListVm
                {
                    SalesSummaries = list
                };

                return vm;
            }
        }
    }
}
