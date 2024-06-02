using System;
using System.Collections.Generic;   
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Negocio
{
    public class N_Categoria
    {

        public static DataTable listar_categoria(string valor)
        {
            D_Categoria datos = new D_Categoria();
            return datos.listar_categoria(valor);
        }


        public static string Guardar_categoria(int nOpcion, E_Categoria oCa)
        {
            D_Categoria datos = new D_Categoria();
            return datos.Guardar_categoria(nOpcion, oCa);
        }

        public static string Eliminar_categoria(int id_categoria)
        {
            D_Categoria datos = new D_Categoria();
            return datos.Eliminar_categoria(id_categoria);
        }

    }


}
