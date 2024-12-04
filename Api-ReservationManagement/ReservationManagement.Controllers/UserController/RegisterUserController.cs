using Microsoft.AspNetCore.Mvc;
using ReservationManagement.DTOs;
using ReservationManagement.Presenters;
using ReservationManagement.UseCasesPorts.UserPort;
using ReservationManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUserController:ControllerBase
    {
        readonly IRegisterUserInputPort InputPort;
        readonly IRegisterUserOutputPort OutputPort;
        //readonly BCryptPasswordHasher PasswordHasher;
        public RegisterUserController(
            IRegisterUserInputPort inputPort,
            IRegisterUserOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserDTO user)
        {   
            try
            {
                //if (user.PasswordHash != null) { var hashedPassword = PasswordHasher.HashPassword(user.PasswordHash); }
                Console.WriteLine("Controller");
                await InputPort.Handle(user);
                var result = ((IPresenter<UserDTO>)OutputPort).Content;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Ha ocurrido un error inesperado." });
            }
            
        }
    }
}
