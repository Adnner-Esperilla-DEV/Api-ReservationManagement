using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)] 
        public string Email { get; set; }
        // Rol = ADMIN || CLIENTE
        public string Rol { get; set; }
        //public ICollection<Booking> Bookings { get; set; }
    }
}
