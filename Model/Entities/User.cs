using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User//:BaseEntity<Guid>
        
    {
        public Guid Id { get; set; }
       public virtual ICollection<Role> Roles { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; } = string.Empty;
       

    }
}
