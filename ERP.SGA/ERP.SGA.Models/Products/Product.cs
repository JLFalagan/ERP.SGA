using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class Product : BaseEntity, IAudity
    {
        public Product()
        {
            
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual long TypeId { get; set; }
        public virtual ProductType Type { get; set; }

        public virtual long CostId { get; set; }
        public virtual Cost Cost { get; set; }

        public virtual long? ColorId { get; set; }
        public virtual Color Color { get; set; }

        public virtual long? ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }

        public virtual List<ProductImage> Images { get; set; }

        public virtual List<TechnicalInformation> TechnicalInformation { get; set; }

        public virtual List<ProductVehicle> Vehicles { get; set; }

        //Auditoria
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
