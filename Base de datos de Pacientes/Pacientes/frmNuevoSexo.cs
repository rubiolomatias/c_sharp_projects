using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class frmNuevoSexo : Form
    {
        public frmNuevoSexo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if(txtSexo.Text.Trim() == "")
            {
                MessageBox.Show("No se puede guardar cadenas vacias");
                correcto = false;
            }
            if (correcto)
            {
                Sexos nuevosexo = new Sexos(txtSexo.Text.Trim());
                if (nuevosexo.Nuevo())
                {
                    MessageBox.Show("El sexo se guardo exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            Close();
        }
    }
}
