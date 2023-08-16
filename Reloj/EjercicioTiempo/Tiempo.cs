using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTiempo
{
    internal class Tiempo
    {
        #region Atributos
        private int hora;
        private int minutos;
        private int segundos;
        #endregion

        #region Propiedades
        public int Hora
        {
            set { hora = ValidarHoras(value); }
            get { return hora; }
        }
        public int Minutos
        {
            set { minutos = ValidarMinutos(value); }
            get { return minutos; }
        }
        public int Segundos
        {
            set { segundos = ValidarSegundos(value); }
            get { return segundos; }
        }
        #endregion

        #region Constructores
        public Tiempo(int pHora,int pMinutos, int pSegundos)
        {
            Hora = pHora;
            Minutos = pMinutos;
            Segundos = pSegundos;
        }
        public Tiempo(int pHora,int pMinutos):this(pHora,pMinutos,0)
        {
            Hora =pHora;
            Minutos = pMinutos;

        }
        public Tiempo(int pHora):this(pHora,0) 
        {
            Hora = pHora;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return Hora.ToString().PadLeft(2,'0') +":"+Minutos.ToString().PadLeft(2, '0') + ":"+Segundos.ToString().PadLeft(2, '0');
        }
        private int ValidarSegundos(int pSegundos)
        {
            if(pSegundos >= 0 && pSegundos < 60)
            {
                return pSegundos;
            }
            else
            {
                return 0;
            }
        }
        private int ValidarMinutos(int pMinutos)
        {
            if (pMinutos >= 0 && pMinutos < 60)
            {
                return pMinutos;
            }
            else
            {
                return 0;
            }
        }
        private int ValidarHoras(int pHoras)
        {
            if(pHoras >= 0 && pHoras <= 23)
            {
                return pHoras;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
