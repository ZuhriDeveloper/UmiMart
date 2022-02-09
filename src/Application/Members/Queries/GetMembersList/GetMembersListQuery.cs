using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.Members.Queries.GetMembersList
{
   public class GetMembersListQuery : IRequest<MembersListVm>
    {
        public class GetMembersListQueryHandler : IRequestHandler<GetMembersListQuery, MembersListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetMembersListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<MembersListVm> Handle(GetMembersListQuery request, CancellationToken cancellationToken)
            {
                var members = await _context.Members
                    .Where(m => m.IsActive == true)
                    .ProjectTo<MemberLookupDto>(_mapper.ConfigurationProvider)
                    .OrderBy(e => e.FullName)
                    .ToListAsync(cancellationToken);

                var vm = new MembersListVm
                {
                    Members = members
                };

                return vm;
            }
        }
    }
}
