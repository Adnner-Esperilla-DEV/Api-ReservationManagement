using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Entities.POCOs
{
    public  class Booking
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime FechaHora { get; set; }
        public int UsuarioId { get; set; }
        public User User { get; set; }
        public Guid ServicioId { get; set; }
        public Service Servicio { get; set; }
        public string Estado { get; set; }
    }
}
