﻿using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class ProductCategory : BaseEntity, IBaseType
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public virtual List<ProductType> Types { get; set; }
    }
}