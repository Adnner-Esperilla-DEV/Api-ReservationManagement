using Microsoft.Extensions.DependencyInjection;
using ReservationManagement.Presenters.ProductPresenters;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<IRegisterUserOutputPort,
                RegisterUserPresenter>();
            services.AddScoped<IGetAllUsersOutpuPort,
                GetAllUsersPresenter>();
            return services;
        }
    }
}
