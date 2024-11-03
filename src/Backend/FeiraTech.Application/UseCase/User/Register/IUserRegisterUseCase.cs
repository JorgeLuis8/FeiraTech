using FeiraTech.Communication.Requests;
using FeiraTech.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Application.UseCase.User.Register
{
    public interface IUserRegisterUseCase
    {
        public Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson request);
        public Task ValidateUser(RequestRegisterUserJson request);
    }
}