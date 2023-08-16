namespace EjercicioTiempo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.btn1Parametro = new System.Windows.Forms.Button();
            this.btn2Parametros = new System.Windows.Forms.Button();
            this.btn3Parametros = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(86, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(86, 56);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(86, 89);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "Segundos";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(158, 20);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(158, 53);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(158, 86);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(100, 20);
            this.txtSegundos.TabIndex = 5;
            // 
            // btn1Parametro
            // 
            this.btn1Parametro.Location = new System.Drawing.Point(406, 84);
            this.btn1Parametro.Name = "btn1Parametro";
            this.btn1Parametro.Size = new System.Drawing.Size(75, 23);
            this.btn1Parametro.TabIndex = 6;
            this.btn1Parametro.Text = "Solo Hora";
            this.btn1Parametro.UseVisualStyleBackColor = true;
            this.btn1Parametro.Click += new System.EventHandler(this.btn1Parametro_Click);
            // 
            // btn2Parametros
            // 
            this.btn2Parametros.Location = new System.Drawing.Point(387, 51);
            this.btn2Parametros.Name = "btn2Parametros";
            this.btn2Parametros.Size = new System.Drawing.Size(104, 23);
            this.btn2Parametros.TabIndex = 7;
            this.btn2Parametros.Text = "Sin Segundos";
            this.btn2Parametros.UseVisualStyleBackColor = true;
            this.btn2Parametros.Click += new System.EventHandler(this.btn2Parametros_Click);
            // 
            // btn3Parametros
            // 
            this.btn3Parametros.Location = new System.Drawing.Point(406, 18);
            this.btn3Parametros.Name = "btn3Parametros";
            this.btn3Parametros.Size = new System.Drawing.Size(75, 23);
            this.btn3Parametros.TabIndex = 8;
            this.btn3Parametros.Text = "Completo";
            this.btn3Parametros.UseVisualStyleBackColor = true;
            this.btn3Parametros.Click += new System.EventHandler(this.btn3Parametros_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(264, 152);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(280, 195);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 10;
            this.lblTiempo.Text = "Tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btn3Parametros);
            this.Controls.Add(this.btn2Parametros);
            this.Controls.Add(this.btn1Parametro);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Button btn1Parametro;
        private System.Windows.Forms.Button btn2Parametros;
        private System.Windows.Forms.Button btn3Parametros;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblTiempo;
    }
}

