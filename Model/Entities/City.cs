using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class City:BaseEntity<Guid>
    {
        public Guid CityStatusId { get; set; }
        public string? CityName { get; set; }
        public Guid ProvinceId { get; set; }
        public Province? Province { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

    }
}
