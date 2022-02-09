using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace UMApplication.Application.Products.Queries.GetProductList
{
    public class GetProductsListQuery : IRequest<ProductListVm>
    {
        public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, ProductListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetProductsListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ProductListVm> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
            {
                var products = await _context.Products
                   .Where(p => p.IsActive == true)
                   .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                   .OrderBy(e => e.Deskripsi)
                   .ToListAsync(cancellationToken);

                var vm = new ProductListVm
                {
                    Products = products
                };

                return vm;
            }
        }
    }
}
