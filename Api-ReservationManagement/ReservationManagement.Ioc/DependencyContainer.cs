using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReservationManagement.Presenters;
using ReservationManagement.RepositoryEFCore;
using ReservationManagement.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Ioc
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddReservationManagementDependecies(
            this IServiceCollection service, IConfiguration configuration)
        {
            service.AddRepositories(configuration);
            service.AddUseCasesServices();
            service.AddPresenters();
            return service;
        }
    }
}
