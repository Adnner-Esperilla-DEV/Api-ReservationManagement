using Microsoft.AspNetCore.Mvc;
using ReservationManagement.DTOs;
using ReservationManagement.Presenters;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllUsersController
    {
        readonly IGetAllUsersInputPort InputPort;
        readonly IGetAllUsersOutpuPort OutputPort;

        public GetAllUsersController(
            IGetAllUsersInputPort inputPort,
            IGetAllUsersOutpuPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);
        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAllUser()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<UserDTO>>)OutputPort).Content;
        }
    }
}
