using ReservationManagement.DTOs;
using ReservationManagement.Entities.Interfaces;
using ReservationManagement.Entities.POCOs;
using ReservationManagement.Services;
using ReservationManagement.UseCasesPorts.UserPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.UseCases.UserUseCase
{
    public class RegisterUserInteractor : IRegisterUserInputPort
    {
        readonly IUserRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly IRegisterUserOutputPort OutputPort;
        //readonly BCryptPasswordHasher PasswordHasher;
        public RegisterUserInteractor(IUserRepository repository,
            IUnitOfWork unitOfWork,
            IRegisterUserOutputPort outputPort) =>
            (Repository, UnitOfWork, OutputPort) =
            (repository,unitOfWork,outputPort);
        public async Task Handle(RegisterUserDTO user)
        {
            //if (await Repository.EmailExistsAsync(user.Email))
            //{
            //    throw new InvalidOperationException("El correo electrónico ya está en uso.");
            //}
            BCryptPasswordHasher passwordHasher = new BCryptPasswordHasher();
            string hashedPassword = passwordHasher.HashPassword(user.PasswordHash);
            User newUser = new User
            {
                Nombre = user.Nombre,
                Email = user.Email,
                Rol= user.Rol,
                PasswordHash = hashedPassword,
            };
            Repository.RegisterUser(newUser);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(
                new UserDTO
                {
                    Id = newUser.Id,
                    Nombre= newUser.Nombre,
                    Email= newUser.Email,
                    Rol = newUser.Rol,                   
                });
        }
    }
}
