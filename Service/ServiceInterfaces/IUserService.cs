using DataTransferObject.DTOClasses;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Service.ServiceInterfaces
{
    public interface IUserService:IServiceBase<User,UserDTO,Guid>
    {
        Task<IdentityResult> CreateUser(UserDTO user);
        Task<UserDTO> GetAsync(Guid id);
        Task<List<UserDTO>> GetAllUsers();
        Task<IList<AuthenticationScheme>>GetExternalAuthenticationShemesAsync();
        Task<SignInResult> LoginToSystem(string username,string password);

    }
}
