namespace EjercicioClaseStatic
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.btnConvertirACelsius = new System.Windows.Forms.Button();
            this.btnConvertirAFahrenheit = new System.Windows.Forms.Button();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(55, 33);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(55, 76);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // btnConvertirACelsius
            // 
            this.btnConvertirACelsius.Location = new System.Drawing.Point(277, 71);
            this.btnConvertirACelsius.Name = "btnConvertirACelsius";
            this.btnConvertirACelsius.Size = new System.Drawing.Size(122, 23);
            this.btnConvertirACelsius.TabIndex = 2;
            this.btnConvertirACelsius.Text = "Convertir a Celsius";
            this.btnConvertirACelsius.UseVisualStyleBackColor = true;
            this.btnConvertirACelsius.Click += new System.EventHandler(this.btnConvertirACelsius_Click);
            // 
            // btnConvertirAFahrenheit
            // 
            this.btnConvertirAFahrenheit.Location = new System.Drawing.Point(277, 30);
            this.btnConvertirAFahrenheit.Name = "btnConvertirAFahrenheit";
            this.btnConvertirAFahrenheit.Size = new System.Drawing.Size(122, 23);
            this.btnConvertirAFahrenheit.TabIndex = 3;
            this.btnConvertirAFahrenheit.Text = "Convertir a Fahrenheit";
            this.btnConvertirAFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirAFahrenheit.Click += new System.EventHandler(this.btnConvertirAFahrenheit_Click);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(127, 73);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(127, 30);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 127);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btnConvertirAFahrenheit);
            this.Controls.Add(this.btnConvertirACelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Button btnConvertirACelsius;
        private System.Windows.Forms.Button btnConvertirAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
    }
}

