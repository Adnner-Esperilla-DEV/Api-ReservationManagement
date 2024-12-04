using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.DTOs
{
    public class RegisterUserDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido")]
        public string Email { get; set; }
        // Roe = Admin || Cliente
        [RegularExpression("^(ADMIN|CLIENTE)$", ErrorMessage = "Rol inválido.")]
        public string Rol { get; set; }
        public string PasswordHash { get; set; }
    }
}
