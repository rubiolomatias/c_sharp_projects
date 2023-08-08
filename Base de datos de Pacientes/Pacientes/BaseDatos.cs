using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    static class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();

        static public bool Conectar()
        {
            try
            {
                conn.ConnectionString = @"Data Source=MATY;Initial Catalog=Pacientes_Clase9;Integrated Security=True";
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

        static public DataTable Buscar(string cadenaSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cadenaSQL,conn);
                da.Fill(dt);
            }
            catch(Exception ex) 
            {
                string msg = ex.Message;   
                return null;
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        static public bool EjecutarConsulta(string cadenaSQL)
        {
            bool correcto;
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cadenaSQL,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                correcto = true;
            }catch(Exception)
            {
                correcto = false;
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }
    }
}
