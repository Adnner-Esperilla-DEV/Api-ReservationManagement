using ReservationManagement.DTOs;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Presenters.ProductPresenters
{
    public class RegisterUserPresenter :
        IRegisterUserOutputPort, IPresenter<UserDTO>
    {
        public UserDTO Content { get; private set; }

        public Task Handle(UserDTO user) 
        { 
            Content = user;
            return Task.CompletedTask;
        }
    }
}
