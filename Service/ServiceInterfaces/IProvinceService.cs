using DataTransferObject.DTOClasses;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceInterfaces
{
    public interface IProvinceService : IServiceBase<Province,ProvinceDTO,Guid>
    {
       Task<ProvinceDTO> CreateProvince(ProvinceDTO provinceDTO);
       Task<List<ProvinceDTO>> GetAllProvinceList();
       Task<ProvinceDTO>  GetProvinceById(Guid id);

    }
}
