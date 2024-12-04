using ReservationManagement.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.Interfaces
{
    public interface IUserRepository
    {
        void RegisterUser(User user);
        void LoginUser(User user);
        IEnumerable<User> GetAll();

        Task<bool> EmailExistsAsync(string email);
    }
}
