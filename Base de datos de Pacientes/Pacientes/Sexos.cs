using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    internal class Sexos
    {
        private int id;
        private string descripcion;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public Sexos()
        {

        }
        public Sexos(string pDescripcion)
        {
            Descripcion = pDescripcion;
        }

        public bool Nuevo()
        {
            bool correcto;
            string consulta = "INSERT INTO Sexos (descripcion) VALUES ('" + Descripcion + "')";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }

        public bool Modificar()
        {
            bool correcto;
            string consulta = "UPDATE Sexos SET descripcion = '" + Descripcion + "' WHERE id = " + Id;
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        
        static public bool Eliminar(int idseleccionado)
        {
            bool correcto;
            string consulta = "DELETE FROM Sexos WHERE id = " + idseleccionado;
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }

        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Sexos";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorId(int idBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Sexos WHERE id = " + idBuscado;
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorDescripcion(string Descripcion)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Sexos WHERE descripcion LIKE  '%" + Descripcion + "%'";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }
    }
}
