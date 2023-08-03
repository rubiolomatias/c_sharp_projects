using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    static class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();

        static public bool Conectar()
        {
            try
            {
                conn.ConnectionString = @"Data Source=MATY;Initial Catalog=Mascotas;Integrated Security=True";
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public void Desconectar()
        {
            conn.Close();
        }

        static public DataTable Buscar(string ConsultaSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(ConsultaSQL, conn);
                da.Fill(dt);
            }
            catch
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        static public bool EjecutarConsulta (string ConsultaSQL)
        {
            bool resultado;
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(ConsultaSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultado = true;
            }
            catch { resultado = false; }
            finally
            {
                Desconectar();
            }
            return resultado;
        }
    }
}
