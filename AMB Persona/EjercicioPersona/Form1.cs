using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPersona
{
    public partial class Form1 : Form
    {
        Persona miPersona = new Persona("Matias", "Rubiolo");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Nombre ingresado incorrecto");
                txtNombre.Focus();
            }
            else
            {
                miPersona.Nombre = txtNombre.Text;
                miPersona.Apellido = txtApellido.Text;
                MessageBox.Show("Persona creada exitosamente");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNombre.Focus() ;
            }
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miPersona.Saludar());
        }
    }
}
