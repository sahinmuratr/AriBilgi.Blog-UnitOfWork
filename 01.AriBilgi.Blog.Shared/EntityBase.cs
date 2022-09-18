﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AriBilgi.Blog.Shared
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? ModifedDate { get; set; }
        public string? ModifedBy { get; set; }
    }
}
