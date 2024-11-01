using FeiraTech.Application.Services.AutoMapper;
using FeiraTech.Application.Services.Criptography;
using FeiraTech.Application.UseCase.User.Register;
using Microsoft.Extensions.DependencyInjection;

namespace FeiraTech.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
            UseCase(services);
            PasswordHash(services);
        }

        public static void UseCase(IServiceCollection services)
        {
               services.AddScoped<IUserRegisterUseCase, UserRegisterUseCase>();
            q
        }

        public static void PasswordHash(IServiceCollection services)
        {
            services.AddScoped(options => new PasswordEncripter());
        }




    }

}
