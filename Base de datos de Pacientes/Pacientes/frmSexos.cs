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
    public partial class frmSexos : Form
    {
        public frmSexos()
        {
            InitializeComponent();
        }

        private void LlenarGrilla(DataTable dt)
        {
            dgvSexos.DataSource = null;
            dgvSexos.DataSource = dt;
        }
        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Sexos.BuscarTodo();
            LlenarGrilla(dt);
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id;
            if(!int.TryParse(txtBuscarPorId.Text.Trim(), out id))
            {
                MessageBox.Show("ID ingresado incorrecto");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = Sexos.BuscarPorId(id);
                LlenarGrilla(dt);
            }
        }

        private void btnBuscarPorDescripcion_Click(object sender, EventArgs e)
        {
            if(txtBuscarPorDescripcion.Text.Trim() != "")
            {
                DataTable dt = new DataTable();
                dt = Sexos.BuscarPorDescripcion(txtBuscarPorDescripcion.Text.Trim());
                dgvSexos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Descripcion ingresada invalida");
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoSexo formNuevoSexo = new frmNuevoSexo();
            formNuevoSexo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvSexos.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvSexos.CurrentRow.Cells[0].Value);
                frmModificarSexo formModifcarSexo = new frmModificarSexo(id);
                formModifcarSexo.Show();
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvSexos.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvSexos.CurrentRow.Cells[0].Value);
                DialogResult Borrar = MessageBox.Show("Seguro de eliminar " + dgvSexos.CurrentRow.Cells[1].Value + "?", "Advertencia", MessageBoxButtons.YesNo);
                if(Borrar == DialogResult.Yes)
                {
                    if (!Sexos.Eliminar(id))
                    {
                        MessageBox.Show("Ocurrio un problema al eliminar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila");
            }
        }
    }
}
