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

namespace Service.ServiceClasses
{
    public class UserService : IUserService
    {

        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<UserDTO> CreateUser(UserDTO user)
        {
            var data = TranslateToEntity(user);
            await _userManager.CreateAsync(data);
            return user;
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            var datas = await _userManager.Users.ToListAsync();
            var users = datas.Any() ? datas.Select(TranslateToDTO).ToList() : new List<UserDTO>();
            return users;
        }

        public async Task<UserDTO> GetAsync(Guid Id)
        {
            var data = await _userManager.FindByIdAsync(Id.ToString());
            return TranslateToDTO(data);
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
