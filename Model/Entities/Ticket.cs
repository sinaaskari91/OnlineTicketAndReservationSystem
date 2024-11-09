using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Ticket:BaseEntity<Guid>
    {
        public string Title { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
