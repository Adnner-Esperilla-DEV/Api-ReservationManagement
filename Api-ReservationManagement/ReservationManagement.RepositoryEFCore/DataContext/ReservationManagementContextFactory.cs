using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Design.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.RepositoryEFCore.DataContext
{
    internal class ReservationManagementContextFactory : IDesignTimeDbContextFactory<ReservationManagementContext>
    {
        public ReservationManagementContext CreateDbContext(string[] args)
        {
            var OptionsBuilder =
                new DbContextOptionsBuilder<ReservationManagementContext>();
            OptionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS02;Database=ReservationManagement;Trusted_Connection=true;TrustServerCertificate=true");
            return new ReservationManagementContext(OptionsBuilder.Options);
        }
    }
}
