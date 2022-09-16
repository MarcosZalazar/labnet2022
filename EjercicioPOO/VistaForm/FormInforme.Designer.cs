namespace VistaForm
{
    partial class FormInforme
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
            this.rtbInformeDePasajeros = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInformeDePasajeros
            // 
            this.rtbInformeDePasajeros.Location = new System.Drawing.Point(18, 16);
            this.rtbInformeDePasajeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbInformeDePasajeros.Name = "rtbInformeDePasajeros";
            this.rtbInformeDePasajeros.Size = new System.Drawing.Size(368, 399);
            this.rtbInformeDePasajeros.TabIndex = 0;
            this.rtbInformeDePasajeros.Text = "";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 443);
            this.Controls.Add(this.rtbInformeDePasajeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de pasajeros por transporte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInformeDePasajeros;
    }
}