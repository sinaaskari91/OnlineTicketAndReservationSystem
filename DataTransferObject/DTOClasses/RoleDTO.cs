using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class RoleDTO:BaseDTO<Guid>
    {
        public Guid CreatedUserId { get; set; }
               
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public UserDTO UserDTO { get; set; }
    }
}
