using DataTransferObject.DTOClasses;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;

namespace Service.ServiceClasses
{
    public class UserService : IUserService
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateUser(UserDTO user)
        {
            User data = TranslateToEntity(user);
            return await _userManager.CreateAsync(data);
           
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
         
            var datas = await _userManager.Users.ToListAsync();
            var users = datas.Any() ? datas.Select(TranslateToDTO).ToList() : new List<UserDTO>();
           // var users = datas.Any() ? datas.Select(x=>x.Adapt<UserDTO>()).ToList() : new List<UserDTO>();
            return users;
        }

        public async Task<UserDTO> GetAsync(Guid Id)
        {
            var data = await _userManager.FindByIdAsync(Id.ToString());
            return TranslateToDTO(data);
        }

        public async Task<IList<AuthenticationScheme>> GetExternalAuthenticationShemesAsync()
        {
           return (IList<AuthenticationScheme>)(await _signInManager.GetExternalAuthenticationSchemesAsync());
        }

        public async Task<SignInResult> LoginToSystem(string username, string password)
        {
            SignInResult data = await _signInManager.PasswordSignInAsync(username, password, true, lockoutOnFailure: false);
            return data;
        }

        public UserDTO TranslateToDTO(User entity)
        {
            return entity.Adapt<UserDTO>();

        }

        public User TranslateToEntity(UserDTO dto)
        {
            return dto.Adapt<User>();
        }

       

        
    }
 }
