using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClaseStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirAFahrenheit_Click(object sender, EventArgs e)
        {
            if(txtCelsius.Text != "")
            {
                double temperatura;
                if(double.TryParse(txtCelsius.Text, out temperatura) )
                {
                    string msj = temperatura + "' Celsius es igual a \n" + ConvertidorTemperatura.CelciusaFahrenheit(temperatura) + "' Fahrenheit";
                    MessageBox.Show(msj);
                }
                else
                {
                    MessageBox.Show("Valor ingresado incorrecto");
                }
            }
            else
            {
                MessageBox.Show("No se ingreso ning valor");
            }
        }

        private void btnConvertirACelsius_Click(object sender, EventArgs e)
        {
            if(txtFahrenheit.Text != "")
            {
                double temperatura;
                if(double.TryParse(txtFahrenheit.Text,out temperatura)){
                    string msj = temperatura + "' Fahrenheit es igual a \n" + ConvertidorTemperatura.CelciusaFahrenheit(temperatura) + "' Celsius";
                    MessageBox.Show(msj);
                }
                else
                {
                    MessageBox.Show("Temperatura ingresada incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No se ingreso ning valor");
            }
        }
    }
}
