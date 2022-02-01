﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Products
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public int ID { get; set; }

        Category Category = new Category();
        public Products ()
        {
            ID= 0;
        }
    }
}
