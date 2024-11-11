using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model
{
    public class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }
        /// <summary>
        /// The date time of data has created in system
        /// </summary>
        public DateTime CreatedDateTime { get; set; }
        /// <summary>
        /// The date time of data has updated in system
        /// </summary>
        public DateTime UpdatedDateTime { get; set; }
        public T? CreatedUserId { get; set; }
        public T? UpdatedUserId { get; set; }
        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        
        
    }
}
