using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class TicketDTO:BaseDTO<Guid>
    {
        public DateTime Date { get; set; }
        public DateTime BuyDate { get; set; }
        public UserDTO User { get; set; }
        public Guid UserId { get; set; }
        public int SeatNumber { get; set; }
    }
}
