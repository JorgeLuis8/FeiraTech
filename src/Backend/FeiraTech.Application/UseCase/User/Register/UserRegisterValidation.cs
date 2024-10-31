using FeiraTech.Communication.Requests;
using FluentValidation;

namespace FeiraTech.Application.UseCase.User.Register
{
    public class UserRegisterValidation : AbstractValidator<RequestRegisterUserJson>
    {
        public UserRegisterValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nome é obrigatório.");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email é obrigatório.")
                .EmailAddress()
                .WithMessage("Email inválido.");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Senha é obrigatória.")
                .MinimumLength(6)
                .WithMessage("Senha deve ter no mínimo 6 caracteres.");
            RuleFor(x => x.CPF)
                .NotEmpty()
                .WithMessage("CPF é obrigatório.")
                .Length(11)
                .WithMessage("CPF deve ter 11 caracteres.");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Telefone é obrigatório.")
                .Length(11)
                .WithMessage("Telefone deve ter 11 caracteres.");
        }
    }
}
