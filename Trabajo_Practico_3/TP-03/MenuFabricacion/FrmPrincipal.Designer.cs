
namespace MenuFabricacion
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
            this.btnFabricarProducto = new System.Windows.Forms.Button();
            this.btnFabricacion = new System.Windows.Forms.Button();
            this.btnControlStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFabricarProducto
            // 
            this.btnFabricarProducto.Location = new System.Drawing.Point(61, 50);
            this.btnFabricarProducto.Name = "btnFabricarProducto";
            this.btnFabricarProducto.Size = new System.Drawing.Size(171, 44);
            this.btnFabricarProducto.TabIndex = 0;
            this.btnFabricarProducto.Text = "Fabricar Producto";
            this.btnFabricarProducto.UseVisualStyleBackColor = true;
            this.btnFabricarProducto.Click += new System.EventHandler(this.btnFabricarProducto_Click);
            // 
            // btnFabricacion
            // 
            this.btnFabricacion.Location = new System.Drawing.Point(61, 149);
            this.btnFabricacion.Name = "btnFabricacion";
            this.btnFabricacion.Size = new System.Drawing.Size(171, 44);
            this.btnFabricacion.TabIndex = 1;
            this.btnFabricacion.Text = "Fabricacion";
            this.btnFabricacion.UseVisualStyleBackColor = true;
            this.btnFabricacion.Click += new System.EventHandler(this.btnListarProduccion_Click);
            // 
            // btnControlStock
            // 
            this.btnControlStock.Location = new System.Drawing.Point(61, 254);
            this.btnControlStock.Name = "btnControlStock";
            this.btnControlStock.Size = new System.Drawing.Size(171, 44);
            this.btnControlStock.TabIndex = 2;
            this.btnControlStock.Text = "Control de Stock";
            this.btnControlStock.UseVisualStyleBackColor = true;
            this.btnControlStock.Click += new System.EventHandler(this.btnControlStock_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 352);
            this.Controls.Add(this.btnControlStock);
            this.Controls.Add(this.btnFabricacion);
            this.Controls.Add(this.btnFabricarProducto);
            this.Name = "FrmPrincipal";
            this.Text = "Fabrica Mato Esteban 2C";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFabricarProducto;
        private System.Windows.Forms.Button btnFabricacion;
        private System.Windows.Forms.Button btnControlStock;
    }
}

