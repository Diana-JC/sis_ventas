using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Detalle_Factura
    {

        public int codigo_articulo { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }
     
    }
}
