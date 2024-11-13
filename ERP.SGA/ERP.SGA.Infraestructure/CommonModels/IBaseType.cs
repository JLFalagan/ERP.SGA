using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.Infraestructure.CommonModels
{
    public interface IBaseType
    {
        string Name { get; set; }
        string Comment { get; set; }
    }
}
