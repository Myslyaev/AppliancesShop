﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.BLL.Models
{
    public class ProductInputModel
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }
    }
}