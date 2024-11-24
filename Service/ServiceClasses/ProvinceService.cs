using AngleSharp.Dom;
using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Http;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceClasses
{
    public class ProvinceService : IProvinceService
    {
        private readonly IBaseRepository<Province,Guid> _provinceRepository;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public ProvinceService(IBaseRepository<Province,Guid> provinceRepository,IUserService userService,IHttpContextAccessor contextAccessor)
        {
            _provinceRepository = provinceRepository;
            _userService = userService;
            _HttpContextAccessor = contextAccessor;
;       }
        public async Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO)
        {
            var rootfolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads");
            var address = Path.Combine(rootfolder, $"{provinceDTO.ProvinceName}-{provinceDTO.ProvinceFile.FileName}");
            provinceDTO.Picture=new BlobDTO() { FileAddress = address,FileSize=(int)(provinceDTO.ProvinceFile.Length/1000) };
            var province = await _provinceRepository.CreateDataAsync(TranslateToEntity(provinceDTO));
          //  var province=TranslateToEntity(provinceDTO);    
            province.CreatedDateTime = DateTime.Now;
            province.UpdatedDateTime=DateTime.Now;
           
            return provinceDTO;
        }

        public async Task<List<ProvinceDTO>> GetAllProvinceList()
        {
            var provinces = await _provinceRepository.GetAllAsync();
            return provinces.ProjectToType<ProvinceDTO>().ToList();
        }

        public async Task<ProvinceDTO> GetProvinceById(Guid id)
        {
            var data = await _provinceRepository.GetByIdAsync(id);
            return TranslateToDTO(data);
;        }

        public ProvinceDTO TranslateToDTO(Province entity)
        {
            return entity.Adapt<ProvinceDTO>();
        }

        public Province TranslateToEntity(ProvinceDTO dto)
        {
            return dto.Adapt<Province>();
        }
    }
}
