using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.V_SalesSummaryPerItem.Queries.GetSalesSummaryListPerItem
{
    public class GetSalesSummaryListPerItemQuery : IRequest<SalesSummaryPerItemListVm>
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Filter { get; set; }

        public class GetSalesSummaryListPerItemQueryHandler : IRequestHandler<GetSalesSummaryListPerItemQuery,SalesSummaryPerItemListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public GetSalesSummaryListPerItemQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<SalesSummaryPerItemListVm> Handle(GetSalesSummaryListPerItemQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var list = await _context.V_SalesSummariesPerItems
                   .Where(x => x.Tgl_Transaksi >= request.DateFrom && x.Tgl_Transaksi <= request.DateTo
                       && (x.Name.Contains(request.Filter) || (x.Code.Contains(request.Filter))))
                   .ProjectTo<SalesSummaryPerItemDto>(_mapper.ConfigurationProvider)
                   .OrderBy(x => x.Tgl_Transaksi).ThenBy(x => x.Code)
                   .ToListAsync(cancellationToken);

                    var vm = new SalesSummaryPerItemListVm
                    {
                        SalesSummariesPerItems = list
                    };

                    return vm;
                }
                catch (Exception ex)
                {
                    var a = ex.Message;
                }

                return null;
               
            }
        }
    }
}
