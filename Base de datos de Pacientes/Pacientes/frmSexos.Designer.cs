namespace Pacientes
{
    partial class frmSexos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorDescripcion = new System.Windows.Forms.TextBox();
            this.btnBuscarPorDescripcion = new System.Windows.Forms.Button();
            this.btnBuscarTodo = new System.Windows.Forms.Button();
            this.dgvSexos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorId);
            this.groupBox1.Controls.Add(this.txtBuscarPorId);
            this.groupBox1.Location = new System.Drawing.Point(38, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por ID";
            // 
            // txtBuscarPorId
            // 
            this.txtBuscarPorId.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorId.Name = "txtBuscarPorId";
            this.txtBuscarPorId.Size = new System.Drawing.Size(286, 20);
            this.txtBuscarPorId.TabIndex = 1;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(334, 27);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 2;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPorDescripcion);
            this.groupBox2.Controls.Add(this.txtBuscarPorDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(38, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Descripcion";
            // 
            // txtBuscarPorDescripcion
            // 
            this.txtBuscarPorDescripcion.Location = new System.Drawing.Point(18, 29);
            this.txtBuscarPorDescripcion.Name = "txtBuscarPorDescripcion";
            this.txtBuscarPorDescripcion.Size = new System.Drawing.Size(286, 20);
            this.txtBuscarPorDescripcion.TabIndex = 4;
            // 
            // btnBuscarPorDescripcion
            // 
            this.btnBuscarPorDescripcion.Location = new System.Drawing.Point(334, 27);
            this.btnBuscarPorDescripcion.Name = "btnBuscarPorDescripcion";
            this.btnBuscarPorDescripcion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorDescripcion.TabIndex = 5;
            this.btnBuscarPorDescripcion.Text = "Buscar";
            this.btnBuscarPorDescripcion.UseVisualStyleBackColor = true;
            this.btnBuscarPorDescripcion.Click += new System.EventHandler(this.btnBuscarPorDescripcion_Click);
            // 
            // btnBuscarTodo
            // 
            this.btnBuscarTodo.Location = new System.Drawing.Point(193, 175);
            this.btnBuscarTodo.Name = "btnBuscarTodo";
            this.btnBuscarTodo.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarTodo.TabIndex = 4;
            this.btnBuscarTodo.Text = "Buscar Todo";
            this.btnBuscarTodo.UseVisualStyleBackColor = true;
            this.btnBuscarTodo.Click += new System.EventHandler(this.btnBuscarTodo_Click);
            // 
            // dgvSexos
            // 
            this.dgvSexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSexos.Location = new System.Drawing.Point(38, 204);
            this.dgvSexos.Name = "dgvSexos";
            this.dgvSexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSexos.Size = new System.Drawing.Size(420, 150);
            this.dgvSexos.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(124, 360);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(205, 360);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmSexos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 406);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvSexos);
            this.Controls.Add(this.btnBuscarTodo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSexos";
            this.Text = "Sexos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtBuscarPorId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPorDescripcion;
        private System.Windows.Forms.TextBox txtBuscarPorDescripcion;
        private System.Windows.Forms.Button btnBuscarTodo;
        private System.Windows.Forms.DataGridView dgvSexos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}