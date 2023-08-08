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
    public partial class frmModificarSexo : Form
    {
        Sexos sex = new Sexos();
        public frmModificarSexo(int idSeleccionado)
        {
            InitializeComponent();
            if(idSeleccionado > 0)
            {
                DataTable dt = new DataTable();
                dt = Sexos.BuscarPorId(idSeleccionado);
                if(dt.Rows.Count > 0)
                {
                    sex.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    sex.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                    txtSexo.Text = sex.Descripcion;
                }
                else
                {
                    MessageBox.Show("No se encontro ning elemento");
                }
            }
            else
            {
                MessageBox.Show("ID ingresado invalido");
            }
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
                MessageBox.Show("Modificacion no valida");
                correcto = false;
            }
            if (correcto)
            {
                sex.Descripcion = txtSexo.Text.Trim();
                if (sex.Modificar())
                {
                    MessageBox.Show("Sexo actulizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
    }
}
