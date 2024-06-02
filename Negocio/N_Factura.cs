using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Factura
    {
        private D_Factura D_Factura = new D_Factura();

        public void SP_Guardar_Factura(D_Factura factura)
        {
            D_Factura.SP_Guardar_Factura(factura);
        }


        public List<E_Factura> SP_Listar_Facturas()
        {
            return E_Factura.SP_Listar_Facturas();
        }
    }
}
