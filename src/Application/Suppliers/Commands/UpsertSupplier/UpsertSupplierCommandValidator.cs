using FluentValidation;

namespace UMApplication.Application.Suppliers.Commands.UpsertSupplier
{
    public class UpsertSupplierCommandValidator : AbstractValidator<UpsertSupplierCommand>
    {
        public UpsertSupplierCommandValidator()
        {
            RuleFor(x => x.Nama).NotEmpty();
            RuleFor(x => x.ContactPerson).NotEmpty();
            RuleFor(x => x.Telepon).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().When(x => x.Email != "");
        }
    }
}
