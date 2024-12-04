using ReservationManagement.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.Interfaces
{
    public  interface IBookingRepository
    {
        void CreateBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(Booking booking);
        IEnumerable<Booking> GetAll();
    }
}
