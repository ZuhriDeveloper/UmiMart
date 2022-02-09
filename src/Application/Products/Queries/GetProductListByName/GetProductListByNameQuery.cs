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
    public class GetProductsListByNameQuery : IRequest<ProductListVm>
    {

        public string filter { get; set; }
        public class GetProductsListByNameQueryHandler : IRequestHandler<GetProductsListByNameQuery, ProductListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetProductsListByNameQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ProductListVm> Handle(GetProductsListByNameQuery request, CancellationToken cancellationToken)
            {
                var products = await _context.Products
                   .Where(p => p.IsActive == true && p.Name.Contains(request.filter))
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
