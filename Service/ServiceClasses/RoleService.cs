using DataTransferObject.DTOClasses;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceClasses
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<RoleDTO> CreateRole(RoleDTO roleDTO)
        {
            var data = TranslateToEntity(roleDTO);
            await _roleManager.CreateAsync(data);
            return roleDTO;
        }

       

        public RoleDTO TranslateToDTO(Role role)
        {
            return role.Adapt<RoleDTO>();
        }

       public Role TranslateToEntity(RoleDTO dto)
        {
            return dto.Adapt<Role>();
        }

    
    }
}
