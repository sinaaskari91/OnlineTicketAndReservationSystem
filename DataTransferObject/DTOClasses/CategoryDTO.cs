﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTOClasses
{
    public class CategoryDTO:BaseDTO<Guid>
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

    }
}
