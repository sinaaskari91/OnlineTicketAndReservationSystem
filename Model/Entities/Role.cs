using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Role:BaseEntity<Guid>
    {
        public int RoleId { get; set; }
        //[ForeignKey(nameof(User))]
        //public Guid UserId { get; set; }
       //          CreatedUserId
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        //public User User { get; set; }
    }
}
