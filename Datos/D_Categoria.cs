using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class D_Categoria
    {

        public DataTable listar_categoria(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_listar_categoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                con.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                con = null;
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public string Guardar_categoria(int nOpcion, E_Categoria oCa)
        {
            string respuesta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("SP_Guardar_cat", Sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                cmd.Parameters.Add("@nId_categoria", SqlDbType.Int).Value = oCa.id_categoria;
                cmd.Parameters.Add("@nNombre", SqlDbType.VarChar).Value = oCa.nombre;
                cmd.Parameters.Add("@nProducto", SqlDbType.VarChar).Value = oCa.producto;
                Sqlcon.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ejecutó el proceso.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                {
                    Sqlcon.Close();
                }
            }
            return respuesta;
        }
    }
}
