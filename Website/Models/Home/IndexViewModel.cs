﻿using System.Collections.Generic;
using Website.Data.Entities;

namespace Website.Models.Home
{
    public class IndexViewModel
    {
     
        public string Name { get; set; }
        public List<Users> Users { get; set; }
         
    }
}