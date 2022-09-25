namespace TP4.UI
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
            this.lblSuplierSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnInfoSupplier = new System.Windows.Forms.Button();
            this.btnInfoAllSuppliers = new System.Windows.Forms.Button();
            this.lblShipper = new System.Windows.Forms.Label();
            this.lstShippers = new System.Windows.Forms.ListBox();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnInfoShipper = new System.Windows.Forms.Button();
            this.btnInfoAllShipper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuplierSubtitle
            // 
            this.lblSuplierSubtitle.AutoSize = true;
            this.lblSuplierSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblSuplierSubtitle.Name = "lblSuplierSubtitle";
            this.lblSuplierSubtitle.Size = new System.Drawing.Size(67, 13);
            this.lblSuplierSubtitle.TabIndex = 0;
            this.lblSuplierSubtitle.Text = "Proveedores";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(277, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Consultas de informacion de la base de datos Northwind";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(25, 75);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(731, 108);
            this.lstSuppliers.TabIndex = 2;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(25, 204);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(99, 48);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "Agregar";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(182, 204);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(99, 48);
            this.btnUpdateSupplier.TabIndex = 4;
            this.btnUpdateSupplier.Text = "Modificar";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(340, 204);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(99, 48);
            this.btnDeleteSupplier.TabIndex = 5;
            this.btnDeleteSupplier.Text = "Eliminar";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnInfoSupplier
            // 
            this.btnInfoSupplier.Location = new System.Drawing.Point(504, 204);
            this.btnInfoSupplier.Name = "btnInfoSupplier";
            this.btnInfoSupplier.Size = new System.Drawing.Size(99, 48);
            this.btnInfoSupplier.TabIndex = 6;
            this.btnInfoSupplier.Text = "Informacion del proveedor";
            this.btnInfoSupplier.UseVisualStyleBackColor = true;
            this.btnInfoSupplier.Click += new System.EventHandler(this.btnInfoSupplier_Click);
            // 
            // btnInfoAllSuppliers
            // 
            this.btnInfoAllSuppliers.Location = new System.Drawing.Point(657, 204);
            this.btnInfoAllSuppliers.Name = "btnInfoAllSuppliers";
            this.btnInfoAllSuppliers.Size = new System.Drawing.Size(99, 48);
            this.btnInfoAllSuppliers.TabIndex = 7;
            this.btnInfoAllSuppliers.Text = "Informacion de todos los proveedores";
            this.btnInfoAllSuppliers.UseVisualStyleBackColor = true;
            this.btnInfoAllSuppliers.Click += new System.EventHandler(this.btnInfoAllSuppliers_Click);
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(25, 276);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(68, 13);
            this.lblShipper.TabIndex = 8;
            this.lblShipper.Text = "Transportista";
            // 
            // lstShippers
            // 
            this.lstShippers.FormattingEnabled = true;
            this.lstShippers.Location = new System.Drawing.Point(25, 309);
            this.lstShippers.Name = "lstShippers";
            this.lstShippers.Size = new System.Drawing.Size(731, 108);
            this.lstShippers.TabIndex = 9;
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.Location = new System.Drawing.Point(25, 440);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(99, 48);
            this.btnAddShipper.TabIndex = 10;
            this.btnAddShipper.Text = "Agregar";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.Location = new System.Drawing.Point(182, 440);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(99, 48);
            this.btnUpdateShipper.TabIndex = 11;
            this.btnUpdateShipper.Text = "Modificar";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(340, 440);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(99, 48);
            this.btnDeleteShipper.TabIndex = 12;
            this.btnDeleteShipper.Text = "Eliminar";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnInfoShipper
            // 
            this.btnInfoShipper.Location = new System.Drawing.Point(504, 440);
            this.btnInfoShipper.Name = "btnInfoShipper";
            this.btnInfoShipper.Size = new System.Drawing.Size(99, 48);
            this.btnInfoShipper.TabIndex = 13;
            this.btnInfoShipper.Text = "Informacion del transportista";
            this.btnInfoShipper.UseVisualStyleBackColor = true;
            this.btnInfoShipper.Click += new System.EventHandler(this.btnInfoShipper_Click);
            // 
            // btnInfoAllShipper
            // 
            this.btnInfoAllShipper.Location = new System.Drawing.Point(657, 440);
            this.btnInfoAllShipper.Name = "btnInfoAllShipper";
            this.btnInfoAllShipper.Size = new System.Drawing.Size(99, 48);
            this.btnInfoAllShipper.TabIndex = 14;
            this.btnInfoAllShipper.Text = "Informacion de todos los transportistas";
            this.btnInfoAllShipper.UseVisualStyleBackColor = true;
            this.btnInfoAllShipper.Click += new System.EventHandler(this.btnInfoAllShipper_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 512);
            this.Controls.Add(this.btnInfoAllShipper);
            this.Controls.Add(this.btnInfoShipper);
            this.Controls.Add(this.btnDeleteShipper);
            this.Controls.Add(this.btnUpdateShipper);
            this.Controls.Add(this.btnAddShipper);
            this.Controls.Add(this.lstShippers);
            this.Controls.Add(this.lblShipper);
            this.Controls.Add(this.btnInfoAllSuppliers);
            this.Controls.Add(this.btnInfoSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.lstSuppliers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSuplierSubtitle);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuplierSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnInfoSupplier;
        private System.Windows.Forms.Button btnInfoAllSuppliers;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.ListBox lstShippers;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnInfoShipper;
        private System.Windows.Forms.Button btnInfoAllShipper;
    }
}

