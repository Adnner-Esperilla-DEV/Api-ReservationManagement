using ReservationManagement.Entities.Interfaces;
using ReservationManagement.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ReservationManagementContext Context;
        public UnitOfWork(ReservationManagementContext context) =>
            Context = context;  
        public Task<int> SaveChanges()
        {
            return Context.SaveChangesAsync();
        }
    }
}
