using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    internal class Pacientes
    {
        private int id;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int idSexo;
        private long dni;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }
        public int IdSexo
        {
            set { idSexo = value; }
            get { return idSexo; }
        }
        public long Dni
        {
            set { dni = value; }
            get { return dni; }
        }

        public Pacientes() { }
        public Pacientes (string pNombre,string pApellido,DateTime pfechaNacimiento,int pidSexo,long pDni)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNacimiento = pfechaNacimiento;
            IdSexo = pidSexo;
            Dni = pDni;
        }

        public bool Nuevo()
        {
            bool correcto;
            string consulta = "INSERT INTO Pacientes (nombre,apellido,fechaNacimiento,idsexo,dni) " +
                "VALUES ('" + Nombre + "','" + Apellido + "','" + FechaNacimiento + "'," + IdSexo + "," + Dni + ")";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        public bool Modificar()
        {
            bool correcto;
            string consulta = "UPDATE Pacientes SET nombre = '" + Nombre + "',apellido = '" + Apellido + "',fechaNacimiento = '" + FechaNacimiento + "', idsexo = " + IdSexo + "," + Dni + " WHERE id = " + Id;
            correcto = BaseDatos.EjecutarConsulta (consulta);
            return correcto;
        }

        static public bool Elimianr (int idSeleccionado)
        {
            bool correcto;
            string consulta = "DELETE FROM Pacientes WHERE id = " + idSeleccionado;
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }

        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorId(int idBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id WHERE Pacientes.id = "+ idBuscado;
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorNombre(string NombreBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id WHERE Pacientes.nombre LIKE '%" + NombreBuscado + "%'";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorApellido(string ApellidoBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id WHERE Pacientes.apellido LIKE '%" + ApellidoBuscado + "%'";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorDni(long DniBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id WHERE Pacientes.dni = " + DniBuscado;
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

        static public DataTable BuscarPorSexo(string SexoBuscado)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pacientes.id as ID,Pacientes.apellido as Apellido,Pacientes.nombre as Nombre,Pacientes.fechaNacimiento as FechaNacimiento,Sexos.descripcion as Sexo,Pacientes.dni as DNI " +
                "FROM Pacientes INNER JOIN Sexos ON Pacientes.idsexo = Sexos.id WHERE pacientes.idSexo = " + SexoBuscado;
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }

    }
}
