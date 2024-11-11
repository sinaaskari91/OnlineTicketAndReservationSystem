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
    public class CityService:ICityService
    {
        private readonly IBaseRepository<City, Guid> _cityRepository;
        public CityService(IBaseRepository<City, Guid> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public CityDTO TranslateToDTO(City entity)
        {
            return entity.Adapt<CityDTO>();
        }

        public City TranslateToEntity(CityDTO dto)
        {
            return dto.Adapt<City>();   
        }
    }
}
