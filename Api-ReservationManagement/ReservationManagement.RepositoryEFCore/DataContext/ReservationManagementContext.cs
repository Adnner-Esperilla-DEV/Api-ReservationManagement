using Microsoft.EntityFrameworkCore;
using ReservationManagement.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.RepositoryEFCore.DataContext
{
    public class ReservationManagementContext : DbContext
    {
        public ReservationManagementContext(
            DbContextOptions<ReservationManagementContext> options): base(options){ }

        public DbSet<User> Users { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
