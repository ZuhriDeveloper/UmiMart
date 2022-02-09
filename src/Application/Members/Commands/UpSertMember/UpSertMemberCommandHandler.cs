using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;

namespace UMApplication.Application.Members.Commands.UpSertMember
{
    public class UpSertMemberCommandHandler : IRequestHandler<UpSertMemberCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpSertMemberCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpSertMemberCommand request, CancellationToken cancellationToken)
        {

            Member entity;

            if (request.Id.HasValue && request.Id > 0)
            {
                entity = await _context.Members.FindAsync(request.Id.Value);
            }
            else
            {
                entity = new Member();
                _context.Members.Add(entity);
            }

            entity.FullName = request.FullName;
            entity.MembershipNumber = request.MembershipNumber;
            entity.CardNumber = "";
            entity.Address = request.Address;
            entity.IsActive = request.IsActive;
            entity.Plafon = request.Plafon;
            entity.DiscountFlat = request.DiscountFlat;
            entity.DiscountRate = request.DiscountRate;

            await _context.SaveChangesAsync(cancellationToken);

            return entity.MemberId;
        }
    }
}
