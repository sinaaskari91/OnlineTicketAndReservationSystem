using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class TicketDTO:BaseDTO<Guid>
    {
        public string Title { get; set; }
        public Guid CategoryId { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
