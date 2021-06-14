
namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.rtbFabricacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFabricacion
            // 
            this.rtbFabricacion.Location = new System.Drawing.Point(0, 0);
            this.rtbFabricacion.Name = "rtbFabricacion";
            this.rtbFabricacion.Size = new System.Drawing.Size(557, 362);
            this.rtbFabricacion.TabIndex = 0;
            this.rtbFabricacion.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 374);
            this.Controls.Add(this.rtbFabricacion);
            this.Name = "FrmPrincipal";
            this.Text = "Mato Esteban 2C \"Fabricación\"";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFabricacion;
    }
}

