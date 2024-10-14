using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class UserDTO:BaseDTO<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; } = string.Empty;
        public virtual ICollection<RoleDTO> Role { get; set; }
        public virtual ICollection<TicketDTO> Ticket { get; set; }
    }
}
