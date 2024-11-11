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

            TypeAdapterConfig<RoleDTO, Role>.NewConfig()
                .Map(x => x.RoleName, y => y.RoleName)
                .Map(x => x.RoleDescription, y => y.RoleDescription);
            TypeAdapterConfig<User, UserDTO>.NewConfig()
              .Map(x => x.Email, y => y.UserName);

            TypeAdapterConfig<UserDTO, User>.NewConfig()
               .Map(x => x.UserName, y => y.Email)
                 .Map(x => x.PasswordHash, x => x.Password)
               .Map(x => x.PasswordHash, x => x.ConfirmPassword);

            TypeAdapterConfig<BlobDTO, Blob>.NewConfig()
              .Map(x => x.FileAddress, y => y.FileAddress)
              .Map(x=>x.MimeType,y=>y.MimeType)
              .Map(x=>x.FileSize,y=>y.FileSize);

            TypeAdapterConfig<Blob, BlobDTO>.NewConfig()
              .Map(x => x.FileAddress, y => y.FileAddress)
              .Map(x => x.MimeType, y => y.MimeType)
              .Map(x => x.FileSize, y => y.FileSize);

        }
    }
}
