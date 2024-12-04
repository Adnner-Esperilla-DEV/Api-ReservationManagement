using Microsoft.Extensions.DependencyInjection;
using ReservationManagement.UseCases.UserUseCase;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<IRegisterUserInputPort,
                RegisterUserInteractor>();
            services.AddTransient<IGetAllUsersInputPort
                ,GetAllUsersInteractor>();

            return services;
        }
    }
}
