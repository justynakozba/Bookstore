﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBookStore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }
}