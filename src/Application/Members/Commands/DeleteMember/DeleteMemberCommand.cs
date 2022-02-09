using MediatR;
using UMApplication.Application.Common.Exceptions;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.Members.Commands.DeleteMember
{
    public class DeleteMemberCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteMemberCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Members
                    .FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Member), request.Id);
                }

                entity.IsActive = false;

                await _context.SaveChangesAsync(cancellationToken);


                return Unit.Value;
            }
        }
    }
}
