using ReservationManagement.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.Interfaces
{
    public interface IServiceRepository
    {
        void CreateService(Service service);
        void UpdateService(Service service);
        void DeleteService(Service service);
        IEnumerable<Service> GetAll();
    }
}
