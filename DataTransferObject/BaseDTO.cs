using DataTransferObject.DTOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        public KeyTypeId Id { get; set; }
        /// <summary>
        /// The date time of data has created in system
        /// </summary>
        public DateTime CreatedDateTime { get; set; }
        /// <summary>
        /// The date time of data has updated in system
        /// </summary>
        public DateTime UpdatedDateTime { get; set; }
        public KeyTypeId? CreatedUserId { get; set; }
        public KeyTypeId? UpdatedUserId { get; set; }
        public UserDTO? CreatedUser { get; set; }
        public UserDTO? UpdatedUser { get; set; }
    }
}
