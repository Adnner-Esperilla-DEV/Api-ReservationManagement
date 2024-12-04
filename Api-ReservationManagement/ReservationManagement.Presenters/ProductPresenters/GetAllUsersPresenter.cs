using ReservationManagement.DTOs;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Presenters.ProductPresenters
{
    public class GetAllUsersPresenter :
        IGetAllUsersOutpuPort, IPresenter<IEnumerable<UserDTO>>
    {
        public IEnumerable<UserDTO> Content { get; private set; }

        public Task Handle(IEnumerable<UserDTO> users)
        {
            Content = users;
            return Task.CompletedTask;
        }
    }
}
