using DataTransferObject.DTOClasses;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceInterfaces
{
    public interface IRoleService: IServiceBase<Role, RoleDTO, Guid>
    {
        Task<RoleDTO> CreateRole(RoleDTO roleDTO);


    }
}
