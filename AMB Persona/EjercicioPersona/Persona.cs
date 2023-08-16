using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    internal class Persona
    {
        #region Atributos;
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
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
        #endregion

        #region Constructores
        public Persona (string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }
        #endregion

        #region Metodos
        public string Saludar()
        {
            string saludo = "Hola, " + Nombre + " " + Apellido;
            return saludo;
        }
        #endregion
    }
}
