using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.Members.Queries.GetMemberDetail
{
    public class GetMemberDetailQuery : IRequest<MemberDetailVm>
    {
        public int Id { get; set; }

        public class GetMemberDetailQueryHandler : IRequestHandler<GetMemberDetailQuery, MemberDetailVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetMemberDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<MemberDetailVm> Handle(GetMemberDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Members
                    .Where(e => e.MemberId == request.Id)
                    .ProjectTo<MemberDetailVm>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}
