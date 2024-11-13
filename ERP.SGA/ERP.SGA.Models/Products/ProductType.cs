using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class ProductType : BaseEntity, IBaseType
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public virtual long CategoryId { get; set; }
        public string? CategoryDisplay { get; set; }
        public ProductCategory Category { get; set; }
    }
}
