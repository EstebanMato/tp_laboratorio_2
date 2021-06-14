
namespace MenuFabricacion
{
    partial class FrmCrearProducto
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
            this.rbtnSamsung = new System.Windows.Forms.RadioButton();
            this.rbtnBangho = new System.Windows.Forms.RadioButton();
            this.rbtnHP = new System.Windows.Forms.RadioButton();
            this.rbtnMAC = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.gboxModelo = new System.Windows.Forms.GroupBox();
            this.gboxModelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnSamsung
            // 
            this.rbtnSamsung.AutoSize = true;
            this.rbtnSamsung.Checked = true;
            this.rbtnSamsung.Location = new System.Drawing.Point(14, 27);
            this.rbtnSamsung.Name = "rbtnSamsung";
            this.rbtnSamsung.Size = new System.Drawing.Size(69, 17);
            this.rbtnSamsung.TabIndex = 0;
            this.rbtnSamsung.TabStop = true;
            this.rbtnSamsung.Text = "Samsung";
            this.rbtnSamsung.UseVisualStyleBackColor = true;
            // 
            // rbtnBangho
            // 
            this.rbtnBangho.AutoSize = true;
            this.rbtnBangho.Location = new System.Drawing.Point(127, 27);
            this.rbtnBangho.Name = "rbtnBangho";
            this.rbtnBangho.Size = new System.Drawing.Size(62, 17);
            this.rbtnBangho.TabIndex = 1;
            this.rbtnBangho.Text = "Bangho";
            this.rbtnBangho.UseVisualStyleBackColor = true;
            // 
            // rbtnHP
            // 
            this.rbtnHP.AutoSize = true;
            this.rbtnHP.Location = new System.Drawing.Point(127, 108);
            this.rbtnHP.Name = "rbtnHP";
            this.rbtnHP.Size = new System.Drawing.Size(40, 17);
            this.rbtnHP.TabIndex = 2;
            this.rbtnHP.Text = "HP";
            this.rbtnHP.UseVisualStyleBackColor = true;
            // 
            // rbtnMAC
            // 
            this.rbtnMAC.AutoSize = true;
            this.rbtnMAC.Location = new System.Drawing.Point(13, 108);
            this.rbtnMAC.Name = "rbtnMAC";
            this.rbtnMAC.Size = new System.Drawing.Size(48, 17);
            this.rbtnMAC.TabIndex = 3;
            this.rbtnMAC.Text = "MAC";
            this.rbtnMAC.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(38, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Seleccione el tipo de notebook a fabricar";
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(36, 218);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(108, 47);
            this.btnFabricar.TabIndex = 5;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // gboxModelo
            // 
            this.gboxModelo.Controls.Add(this.rbtnMAC);
            this.gboxModelo.Controls.Add(this.rbtnHP);
            this.gboxModelo.Controls.Add(this.rbtnBangho);
            this.gboxModelo.Controls.Add(this.rbtnSamsung);
            this.gboxModelo.Location = new System.Drawing.Point(36, 57);
            this.gboxModelo.Name = "gboxModelo";
            this.gboxModelo.Size = new System.Drawing.Size(202, 144);
            this.gboxModelo.TabIndex = 6;
            this.gboxModelo.TabStop = false;
            this.gboxModelo.Text = "Modelo";
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 325);
            this.Controls.Add(this.gboxModelo);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCrearProducto";
            this.Text = "Crear Producto";
            this.gboxModelo.ResumeLayout(false);
            this.gboxModelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSamsung;
        private System.Windows.Forms.RadioButton rbtnBangho;
        private System.Windows.Forms.RadioButton rbtnHP;
        private System.Windows.Forms.RadioButton rbtnMAC;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.GroupBox gboxModelo;
    }
}