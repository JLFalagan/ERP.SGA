using ERP.SGA.Infraestructure.CommonModels;
using ERP.SGA.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Vehicles
{
    public class Vehicle : BaseEntity, IAudity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public string Segment { get; set; }
        public string Description { get; set; }

        public virtual long BrandId { get; set; }
        public virtual VehicleBrand Brand { get; set; }

        public virtual long? TypeId { get; set; }
        public virtual VehicleType Type { get; set; }

        public virtual List<Product> Products { get; set; }

        //Auditoria
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
