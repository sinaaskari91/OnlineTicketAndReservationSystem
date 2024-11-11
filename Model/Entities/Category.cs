﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Category:BaseEntity<Guid>
    {
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }
}
