using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using UMApplication.Application.Products.Queries;
using System.Threading.Tasks;

namespace UMApplication.Application.Products.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }

        public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetProductDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ProductDto> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Products
                    .Where(e => e.ProductId == request.Id)
                    .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}
