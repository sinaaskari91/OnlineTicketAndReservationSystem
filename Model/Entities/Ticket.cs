using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Ticket:BaseEntity<Guid>
    {
        public DateTime Date { get; set; }
        public DateTime BuyDate { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public int SeatNumber { get; set; }
    }
}
