using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Factura
    {
        private string connectionString = @"Data Source=DESKTOP-80ATPO4;Initial Catalog=Gestion_ventas;User ID=sa;Password=12345678;Trust Server Certificate=True";

        public static void SP_Guardar_Factura(D_Factura factura)
        {
            throw new NotImplementedException();
        }

        public void SP_Guardar_Factura(E_Factura factura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Guardar_Factura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_producto", factura.codigo_producto);
                cmd.Parameters.AddWithValue("@producto", factura.producto);
                cmd.Parameters.AddWithValue("@codugo_usuario", factura.codigo_usuario);
                cmd.Parameters.AddWithValue("@cantidad", factura.cantidad);
                cmd.Parameters.AddWithValue("@descripcion", factura.descripcion);
                cmd.Parameters.AddWithValue("@total", factura.total);
                cmd.Parameters.AddWithValue("@itbis", factura.itbis);
                cmd.Parameters.AddWithValue("@fecha_factura", factura.fecha_factura);
                cmd.Parameters.AddWithValue("@precio", factura.precio);
                cmd.Parameters.AddWithValue("@nombre_cliente", factura.nombre_cliente);
                cmd.Parameters.AddWithValue("@num_identidad", factura.num_identidad);
                cmd.Parameters.AddWithValue("@RNC", factura.RNC);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<E_Factura> SP_Listar_Facturas()
        {
            List<E_Factura> facturas = new List<E_Factura>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Facturas", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    facturas.Add(new E_Factura
                    {
                        id_factura = (int)reader["id_factura"],
                        cantidad = (decimal)reader["cantidad"],
                        descripcion = (string)reader["descripcion"],
                        total = (decimal)reader["total"],
                        itbis = (decimal)reader["itbis"],
                        precio = (decimal)reader["precio"],
                        codigo_producto = (decimal)reader["codigo_producto"],
                        producto = (string)reader["producto"],
                        nombre_cliente = (string)reader["nombre_cliente"],
                        num_identidad = (decimal)reader["num_identidad"],
                        RNC = (decimal)reader["RNC"],
                    });
                }
            }
            return facturas;
        }
    }
}
