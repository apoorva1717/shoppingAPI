﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopping.Entities
{
    public class Product
    {
        [Key]
        public int PID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public string Gender { get; set; }
        public string MainCategory { get; set; }
        public ICollection<Tags> TagList { get; set; } = new List<Tags>();

    }
}
