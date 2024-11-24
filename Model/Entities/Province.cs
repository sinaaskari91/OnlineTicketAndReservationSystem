using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Province:BaseEntity<Guid>
    {
        public string? ProvinceName { get; set; }
        public Guid? ProvincePictureId { get; set; }
        public Blob? ProvincePicture { get; set; }
        
        public ICollection<City> Cities { get; set; }=new List<City>();
    }
}

