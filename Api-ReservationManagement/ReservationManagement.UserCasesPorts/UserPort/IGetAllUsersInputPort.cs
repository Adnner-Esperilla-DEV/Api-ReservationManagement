using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.UseCasesPorts.UserPort
{
    public interface  IGetAllUsersInputPort
    {
        Task Handle();
    }
}
