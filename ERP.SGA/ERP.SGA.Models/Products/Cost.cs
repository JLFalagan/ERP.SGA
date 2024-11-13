using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class Cost : BaseEntity, IAudity
    {
        public decimal Price { get; set; }      //Precio base de compra
        public decimal Utility { get; set; }    //Utilidad
        public decimal SubTotal { get; set; }   //Precio base + utilidad
        public decimal Total { get; set; }      //Subtotal + impuesto

        //Auditoria
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
