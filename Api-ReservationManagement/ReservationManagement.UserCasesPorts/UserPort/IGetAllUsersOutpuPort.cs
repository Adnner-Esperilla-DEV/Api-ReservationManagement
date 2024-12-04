using ReservationManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.UseCasesPorts.UserPort
{
    public interface IGetAllUsersOutpuPort
    {
        Task Handle(IEnumerable<UserDTO> users);
    }
}
