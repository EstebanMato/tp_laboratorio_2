
namespace MenuFabricacion
{
    partial class FrmControlStock
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
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnGenerarTxt = new System.Windows.Forms.Button();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtMicro = new System.Windows.Forms.TextBox();
            this.lblMicro = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(130, 27);
            this.btnAgregarStock.TabIndex = 0;
            this.btnAgregarStock.Text = "Agregar stock";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // btnGenerarTxt
            // 
            this.btnGenerarTxt.Location = new System.Drawing.Point(309, 145);
            this.btnGenerarTxt.Name = "btnGenerarTxt";
            this.btnGenerarTxt.Size = new System.Drawing.Size(66, 52);
            this.btnGenerarTxt.TabIndex = 6;
            this.btnGenerarTxt.Text = "Generar txt con stock actual";
            this.btnGenerarTxt.UseVisualStyleBackColor = true;
            this.btnGenerarTxt.Click += new System.EventHandler(this.btnGenerarTxt_Click);
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(146, 123);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(130, 20);
            this.txtAlmacenamiento.TabIndex = 3;
            this.txtAlmacenamiento.Text = "0";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(146, 155);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(130, 20);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.Text = "0";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(146, 91);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(130, 20);
            this.txtRam.TabIndex = 2;
            this.txtRam.Text = "0";
            // 
            // txtMicro
            // 
            this.txtMicro.Location = new System.Drawing.Point(146, 59);
            this.txtMicro.Name = "txtMicro";
            this.txtMicro.Size = new System.Drawing.Size(130, 20);
            this.txtMicro.TabIndex = 1;
            this.txtMicro.Text = "0";
            // 
            // lblMicro
            // 
            this.lblMicro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMicro.AutoSize = true;
            this.lblMicro.Location = new System.Drawing.Point(9, 62);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(86, 13);
            this.lblMicro.TabIndex = 6;
            this.lblMicro.Text = "Microprocesador";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(9, 94);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(77, 13);
            this.lblRam.TabIndex = 7;
            this.lblRam.Text = "Memorias Ram";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Location = new System.Drawing.Point(9, 126);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(85, 13);
            this.lblAlmacenamiento.TabIndex = 8;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(9, 158);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(71, 13);
            this.lblPlaca.TabIndex = 9;
            this.lblPlaca.Text = "Placa madres";
            // 
            // FrmControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 209);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.txtMicro);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.btnGenerarTxt);
            this.Controls.Add(this.btnAgregarStock);
            this.Name = "FrmControlStock";
            this.Text = "Control de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnGenerarTxt;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtMicro;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblPlaca;
    }
}