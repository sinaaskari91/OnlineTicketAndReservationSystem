using DataTransferObject.DTOClasses;
using Mapster;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class MapsterConfig
    {
        public static void RegisterMapping()
        {
            TypeAdapterConfig<Role, RoleDTO>.NewConfig()
                .Map(x => x.RoleName, y => y.RoleName)
                .Map(x => x.RoleDescription, y => y.RoleDescription);

           
            //TypeAdapterConfig<User, UserDTO>.NewConfig()
            //   //.Map(x => x.Name, y => y.FirstName)
            //  // .Map(x => x.Family, y => y.LastName)
            //   .Map(x => x.Username, y => y.UserName);





        }
    }
}
