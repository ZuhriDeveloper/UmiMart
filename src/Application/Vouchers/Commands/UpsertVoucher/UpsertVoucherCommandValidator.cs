using FluentValidation;

namespace UMApplication.Application.Vouchers.Commands.UpsertVoucher
{
    public class UpsertVoucherCommandValidator : AbstractValidator<UpsertVoucherCommand>
    {
        public UpsertVoucherCommandValidator()
        {
            RuleFor(x => x.VoucherCode).NotEmpty();
            RuleFor(x => x.Nominal).NotEmpty();
            RuleFor(x => x.Nominal).GreaterThan(0);
            RuleFor(x => x.ValidFromString).NotEmpty();
        }
    }
}
