using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private string Servidor;
        private string Base;
        private string Usuario;
        private string Clave;
        private static Conexion Cn = null;

        private Conexion()
        {
            this.Servidor = "DESKTOP-80ATPO4//Developer";
            this.Base = "Gestion_ventas";
            this.Usuario = "sa";
            this.Clave = "12345678";
        }

        public SqlConnection CreaConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base +
                    ";User Id=" + this.Usuario + ";Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (Cn == null)
            {
                Cn = new Conexion();
            }
            return Cn;
        }
    }
}
