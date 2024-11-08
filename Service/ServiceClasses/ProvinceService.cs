using AngleSharp.Dom;
using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
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
        public ProvinceService(IBaseRepository<Province,Guid> provinceRepository)
        {
            _provinceRepository = provinceRepository;
;       }
      

     

        public async Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO)
        {
           var province= await _provinceRepository.CreateDataAsync(TranslateToEntity(provinceDTO));
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
