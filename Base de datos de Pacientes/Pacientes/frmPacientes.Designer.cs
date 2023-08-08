namespace Pacientes
{
    partial class frmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarTodo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorSexo = new System.Windows.Forms.Button();
            this.txtBuscarPorSexo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorDni = new System.Windows.Forms.Button();
            this.txtBuscarPorDni = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorApellido = new System.Windows.Forms.Button();
            this.txtBuscarPorApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(384, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(303, 420);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(217, 264);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(420, 150);
            this.dgvPacientes.TabIndex = 20;
            // 
            // btnBuscarTodo
            // 
            this.btnBuscarTodo.Location = new System.Drawing.Point(374, 235);
            this.btnBuscarTodo.Name = "btnBuscarTodo";
            this.btnBuscarTodo.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarTodo.TabIndex = 19;
            this.btnBuscarTodo.Text = "Buscar Todo";
            this.btnBuscarTodo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarPorId);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(217, 165);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 64);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar por ID";
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(334, 27);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 5;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 20);
            this.textBox3.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarPorSexo);
            this.groupBox3.Controls.Add(this.txtBuscarPorSexo);
            this.groupBox3.Location = new System.Drawing.Point(422, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 64);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Sexo";
            // 
            // btnBuscarPorSexo
            // 
            this.btnBuscarPorSexo.Location = new System.Drawing.Point(232, 27);
            this.btnBuscarPorSexo.Name = "btnBuscarPorSexo";
            this.btnBuscarPorSexo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorSexo.TabIndex = 5;
            this.btnBuscarPorSexo.Text = "Buscar";
            this.btnBuscarPorSexo.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorSexo
            // 
            this.txtBuscarPorSexo.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorSexo.Name = "txtBuscarPorSexo";
            this.txtBuscarPorSexo.Size = new System.Drawing.Size(190, 20);
            this.txtBuscarPorSexo.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPorDni);
            this.groupBox2.Controls.Add(this.txtBuscarPorDni);
            this.groupBox2.Location = new System.Drawing.Point(54, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por DNI";
            // 
            // btnBuscarPorDni
            // 
            this.btnBuscarPorDni.Location = new System.Drawing.Point(232, 27);
            this.btnBuscarPorDni.Name = "btnBuscarPorDni";
            this.btnBuscarPorDni.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorDni.TabIndex = 5;
            this.btnBuscarPorDni.Text = "Buscar";
            this.btnBuscarPorDni.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorDni
            // 
            this.txtBuscarPorDni.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorDni.Name = "txtBuscarPorDni";
            this.txtBuscarPorDni.Size = new System.Drawing.Size(190, 20);
            this.txtBuscarPorDni.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarPorApellido);
            this.groupBox4.Controls.Add(this.txtBuscarPorApellido);
            this.groupBox4.Location = new System.Drawing.Point(422, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 68);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por Apellido";
            // 
            // btnBuscarPorApellido
            // 
            this.btnBuscarPorApellido.Location = new System.Drawing.Point(232, 27);
            this.btnBuscarPorApellido.Name = "btnBuscarPorApellido";
            this.btnBuscarPorApellido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorApellido.TabIndex = 2;
            this.btnBuscarPorApellido.Text = "Buscar";
            this.btnBuscarPorApellido.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorApellido
            // 
            this.txtBuscarPorApellido.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorApellido.Name = "txtBuscarPorApellido";
            this.txtBuscarPorApellido.Size = new System.Drawing.Size(190, 20);
            this.txtBuscarPorApellido.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorNombre);
            this.groupBox1.Controls.Add(this.txtBuscarPorNombre);
            this.groupBox1.Location = new System.Drawing.Point(54, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Nombre";
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(232, 27);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorNombre.TabIndex = 2;
            this.btnBuscarPorNombre.Text = "Buscar";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(190, 20);
            this.txtBuscarPorNombre.TabIndex = 1;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnBuscarTodo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPacientes";
            this.Text = "frmPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnBuscarTodo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarPorSexo;
        private System.Windows.Forms.TextBox txtBuscarPorSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPorDni;
        private System.Windows.Forms.TextBox txtBuscarPorDni;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarPorApellido;
        private System.Windows.Forms.TextBox txtBuscarPorApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
    }
}