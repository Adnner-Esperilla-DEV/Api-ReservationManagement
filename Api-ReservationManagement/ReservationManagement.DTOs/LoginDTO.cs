﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.DTOs
{
    public class LoginDTO
    {
        [Required]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido")]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
