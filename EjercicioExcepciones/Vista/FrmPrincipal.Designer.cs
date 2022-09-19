namespace Vista
{
    partial class FrmPrincipal
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnEjercicioUno = new System.Windows.Forms.Button();
            this.btnEjercicioDos = new System.Windows.Forms.Button();
            this.btnEjercicioTres = new System.Windows.Forms.Button();
            this.btnEjercicioCuatro = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(23, 23);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(55, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(24, 59);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(39, 13);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(98, 20);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(154, 20);
            this.txtDividendo.TabIndex = 2;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(98, 56);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(154, 20);
            this.txtDivisor.TabIndex = 3;
            // 
            // btnEjercicioUno
            // 
            this.btnEjercicioUno.Location = new System.Drawing.Point(26, 162);
            this.btnEjercicioUno.Name = "btnEjercicioUno";
            this.btnEjercicioUno.Size = new System.Drawing.Size(101, 40);
            this.btnEjercicioUno.TabIndex = 4;
            this.btnEjercicioUno.Text = "Ejercicio Uno";
            this.btnEjercicioUno.UseVisualStyleBackColor = true;
            this.btnEjercicioUno.Click += new System.EventHandler(this.btnEjercicioUno_Click);
            // 
            // btnEjercicioDos
            // 
            this.btnEjercicioDos.Location = new System.Drawing.Point(161, 162);
            this.btnEjercicioDos.Name = "btnEjercicioDos";
            this.btnEjercicioDos.Size = new System.Drawing.Size(101, 40);
            this.btnEjercicioDos.TabIndex = 5;
            this.btnEjercicioDos.Text = "Ejercicio Dos";
            this.btnEjercicioDos.UseVisualStyleBackColor = true;
            this.btnEjercicioDos.Click += new System.EventHandler(this.btnEjercicioDos_Click);
            // 
            // btnEjercicioTres
            // 
            this.btnEjercicioTres.Location = new System.Drawing.Point(296, 162);
            this.btnEjercicioTres.Name = "btnEjercicioTres";
            this.btnEjercicioTres.Size = new System.Drawing.Size(101, 40);
            this.btnEjercicioTres.TabIndex = 6;
            this.btnEjercicioTres.Text = "Ejercicio Tres";
            this.btnEjercicioTres.UseVisualStyleBackColor = true;
            this.btnEjercicioTres.Click += new System.EventHandler(this.btnEjercicioTres_Click);
            // 
            // btnEjercicioCuatro
            // 
            this.btnEjercicioCuatro.Location = new System.Drawing.Point(432, 162);
            this.btnEjercicioCuatro.Name = "btnEjercicioCuatro";
            this.btnEjercicioCuatro.Size = new System.Drawing.Size(101, 40);
            this.btnEjercicioCuatro.TabIndex = 7;
            this.btnEjercicioCuatro.Text = "Ejercicio Cuatro";
            this.btnEjercicioCuatro.UseVisualStyleBackColor = true;
            this.btnEjercicioCuatro.Click += new System.EventHandler(this.btnEjercicioCuatro_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(296, 20);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(237, 121);
            this.rtbResultado.TabIndex = 8;
            this.rtbResultado.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 219);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnEjercicioCuatro);
            this.Controls.Add(this.btnEjercicioTres);
            this.Controls.Add(this.btnEjercicioDos);
            this.Controls.Add(this.btnEjercicioUno);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnEjercicioUno;
        private System.Windows.Forms.Button btnEjercicioDos;
        private System.Windows.Forms.Button btnEjercicioTres;
        private System.Windows.Forms.Button btnEjercicioCuatro;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}

