using Microsoft.EntityFrameworkCore;
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
    public class UserRepository : IUserRepository
    {
        readonly ReservationManagementContext Context;
        public UserRepository(ReservationManagementContext context) =>
            Context = context;

        public void LoginUser(User user)
        {
            Context.Update(user);
        }

        public void RegisterUser(User user)
        {
            Context.Add(user);
        }
        public IEnumerable<User> GetAll()
        {
            return Context.Users;
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await Context.Users.AnyAsync(u => u.Email == email);
        }
    }

}
