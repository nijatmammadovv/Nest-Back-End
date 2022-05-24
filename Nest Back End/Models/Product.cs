﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Back_End.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Raiting { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}
