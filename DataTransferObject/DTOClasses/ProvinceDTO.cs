using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class ProvinceDTO:BaseDTO<Guid>
    {
        [Required (ErrorMessage ="نام استان خود را وارد کنید ")]
        [Display(Name ="نام استان")]
        public string ProvinceName { get; set; }
        public List<CityDTO> Cities { get; set; }
    }
}
