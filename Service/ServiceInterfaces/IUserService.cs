using DataTransferObject.DTOClasses;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceInterfaces
{
    public interface IUserService:IServiceBase<User,UserDTO,Guid>
    {
        Task<UserDTO> CreateUser(UserDTO userDTO);
        Task<UserDTO?> GetAsync(Guid id);
        Task<List<UserDTO>> GetAllUsers();

    }
}
