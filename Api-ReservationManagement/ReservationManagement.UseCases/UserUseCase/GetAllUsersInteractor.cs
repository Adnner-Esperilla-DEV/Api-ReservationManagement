using ReservationManagement.DTOs;
using ReservationManagement.Entities.Interfaces;
using ReservationManagement.Entities.POCOs;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.UseCases.UserUseCase
{
    public class GetAllUsersInteractor : IGetAllUsersInputPort
    {
        readonly IUserRepository Repository;
        readonly IGetAllUsersOutpuPort OutpuPort;
        public GetAllUsersInteractor(IUserRepository repository,
            IGetAllUsersOutpuPort outpuPort) => 
            (Repository, OutpuPort) = (repository, outpuPort);
        public Task Handle()
        {
            var Users = Repository.GetAll().Select(p =>
            new UserDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Email = p.Email,
                Rol = p.Rol,
            });
            OutpuPort.Handle(Users);
            return Task.CompletedTask;
        }
    }
}
