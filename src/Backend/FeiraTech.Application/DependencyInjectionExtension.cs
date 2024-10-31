using FeiraTech.Application.Services.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace FeiraTech.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

        public static void UseCase(IServiceCollection service)
        {
               //services.AddScoped<IUserRegisterUseCase, UserRegisterUseCase>();
        }




    }

}
