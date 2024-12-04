using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.POCOs
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        // Roe = Admin || Cliente
        public string Rol { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
