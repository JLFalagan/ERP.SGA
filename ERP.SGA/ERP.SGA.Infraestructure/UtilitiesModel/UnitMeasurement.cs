using ERP.SGA.Infraestructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Infraestructure.UtilitiesModel
{
    public class UnitMeasurement : BaseEntity, IBaseType
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Comment { get; set; }
    }
}
