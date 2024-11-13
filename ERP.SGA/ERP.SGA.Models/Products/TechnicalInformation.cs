using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Models.Products
{
    public class TechnicalInformation : BaseEntity
    {
        public string Magnitude { get; set; }
        public double Value { get; set; }
    }
}
