using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class BlobDTO:BaseDTO<Guid>
    {
        public string? FileAddress { get; set; }
        public string? MimeType { get; set; }
        public int FileSize { get; set; }
        
    }
}
