using ERP.SGA.Infraestructure.CommonModels;
using ERP.SGA.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class ProductVehicle : BaseEntity
    {
        public virtual long ProductId { get; set; }
        public virtual Product Product { get; set; }

        public virtual long VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
