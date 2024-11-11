using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User:IdentityUser<Guid>
        
    {
        //public Guid Id { get; set; }
      

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        //public string Email {  get; set; }
        //public string Password { get; set; }
      
        public DateTime DateOfBirth { get; set; }
        // public string UserName { get; set; } = string.Empty;
        //public virtual ICollection<Role> Role { get; set; }
        public Guid? CreatedUserId { get; set; }
        /// <summary>
        /// The id of user where updated data in system
        /// </summary>
        public Guid? UpdatedUserId { get; set; }

        public  User? CreateUser { get; set; }

        public  User? UpdateUser { get; set; }

       // public Guid? AvatarId { get; set; }

        public  Blob? Avatar { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
       


    }
}
