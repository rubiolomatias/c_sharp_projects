using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseStatic
{
    static internal class ConvertidorTemperatura
    {
        static public double CelciusaFahrenheit(double pTempCelsius)
        {
            double Fahrenheit = (pTempCelsius * 9 / 5) + 32;
            return Fahrenheit;
        }
        static public double FahrenheitaCelsius(double pTempFahrenheit)
        {
            double Celsius = (pTempFahrenheit - 32) * 9/ 5;
            return Celsius;
        }
    }
}
