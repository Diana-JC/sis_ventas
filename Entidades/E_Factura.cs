using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Factura
    {
        public int id_factura { get; set; }

        public decimal codigo_producto { get; set; }
        public string producto { get; set; }
        public int codigo_usuario { get; set; }
        public decimal cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal total { get; set; }
        public decimal itbis { get; set; }
        public decimal fecha_factura { get; set; }
        public decimal precio { get; set; }
        public string nombre_cliente { get; set; }
        public decimal num_identidad { get; set; }
        public decimal RNC { get; set; }
        public string Estado { get; set; }

        public static List<E_Factura> SP_Listar_Facturas()
        {
            throw new NotImplementedException();
        }
    }



}
