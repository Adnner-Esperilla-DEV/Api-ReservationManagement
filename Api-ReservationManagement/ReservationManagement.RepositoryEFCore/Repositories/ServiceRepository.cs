using ReservationManagement.Entities.Interfaces;
using ReservationManagement.Entities.POCOs;
using ReservationManagement.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.RepositoryEFCore.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        readonly ReservationManagementContext Context;
        public ServiceRepository(ReservationManagementContext context) =>
            Context = context;

        public void CreateService(Service service)
        {
            Context.Add(service);
        }

        public void DeleteService(Service service)
        {
            Context.Remove(service);
        }

        public IEnumerable<Service> GetAll()
        {
            return Context.Services;
        }

        public void UpdateService(Service service)
        {
            Context.Update(service);
        }
    }
}
