using FeiraTech.Communication.Requests;
using FeiraTech.Exceptions;
using FluentValidation;

namespace FeiraTech.Application.UseCase.User.Register
{
    public class UserRegisterValidation : AbstractValidator<RequestRegisterUserJson>
    {
        public UserRegisterValidation()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesExceptions.NAME_EMPTY);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesExceptions.EMAIL_EMPTY);
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesExceptions.EMAIL_INVALID);
            RuleFor(user => user.Password).MinimumLength(6).WithMessage(ResourceMessagesExceptions.PASSWORD_MINIUM);
            RuleFor(user => user.CPF).Length(11).WithMessage(ResourceMessagesExceptions.CPF_INVALID);
        }
    }
}
