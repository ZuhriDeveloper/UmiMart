using FluentValidation;

namespace UMApplication.Application.Members.Commands.UpSertMember
{
    public class UpsertMemberCommandValidator : AbstractValidator<UpSertMemberCommand>
    {
        public UpsertMemberCommandValidator()
        {
            RuleFor(x => x.FullName).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.MembershipNumber).NotEmpty();
            //RuleFor(x => x.CardNumber).NotEmpty();
        }
    }
}
