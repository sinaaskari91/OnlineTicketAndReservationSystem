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


            TypeAdapterConfig<Blob, BlobDTO>.NewConfig()
                .Map(x => x.FileAddress, y => y.FileAddress)
                .Map(x => x.FileSize, y => y.FileSize)
                .Map(x => x.MimeType, y => y.MimeType);

            TypeAdapterConfig<User, UserDTO>.NewConfig()
                .Map(x => x.Email, y => y.Email)
                .Map(x => x.MobileNumber, y => y.PhoneNumber)
                .Map(x => x.Email, y => y.UserName);

            TypeAdapterConfig<UserDTO, User>.NewConfig()
                .Map(x => x.Email, y => y.Email)
                .Map(x => x.PhoneNumber, y => y.MobileNumber)
                .Map(x => x.UserName, y => y.Email)
                .Map(x => x.PasswordHash, y => y.Password);

            TypeAdapterConfig<Blob, BlobDTO>.NewConfig()
                .Map(x => x.FileAddress, y => y.FileAddress)
                .Map(x => x.FileSize, y => y.FileSize)
                .Map(x => x.MimeType, y => y.MimeType);

            TypeAdapterConfig<BlobDTO, Blob>.NewConfig()
                .Map(x => x.FileAddress, y => y.FileAddress)
                .Map(x => x.FileSize, y => y.FileSize)
                .Map(x => x.MimeType, y => y.MimeType);

            TypeAdapterConfig<Province, ProvinceDTO>.NewConfig()
                .Map(x => x.ProvinceName, y => y.ProvinceName)
                .Map(x => x.Picture, y => y.ProvincePicture);

            TypeAdapterConfig<ProvinceDTO, Province>.NewConfig()
                .Map(x => x.ProvinceName, y => y.ProvinceName)
                .Map(x => x.ProvincePicture, y => y.Picture);
        }
    }
}
