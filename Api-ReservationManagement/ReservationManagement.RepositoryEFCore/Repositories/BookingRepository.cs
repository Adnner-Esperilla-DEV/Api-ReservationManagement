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
    public class BookingRepository : IBookingRepository
    {
        readonly ReservationManagementContext Context;
        public BookingRepository(ReservationManagementContext context) =>
            Context = context;

        public void CreateBooking(Booking booking)
        {
            Context.Remove(booking);
        }

        public void DeleteBooking(Booking booking)
        {
            Context.Remove(booking);
        }

        public IEnumerable<Booking> GetAll()
        {
            return Context.Bookings;
        }

        public void UpdateBooking(Booking booking)
        {
            Context.Remove(booking);
        }
    }
}
