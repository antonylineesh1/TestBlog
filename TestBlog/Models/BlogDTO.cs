﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Models
{
    public class BlogDTO
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
