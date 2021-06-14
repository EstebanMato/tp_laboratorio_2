
namespace MenuFabricacion
{
    partial class FrmFabrica
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
            this.rtbListarProduccion = new System.Windows.Forms.RichTextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListarProduccion
            // 
            this.rtbListarProduccion.Location = new System.Drawing.Point(224, 12);
            this.rtbListarProduccion.Name = "rtbListarProduccion";
            this.rtbListarProduccion.Size = new System.Drawing.Size(224, 291);
            this.rtbListarProduccion.TabIndex = 0;
            this.rtbListarProduccion.Text = "";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(193, 54);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Produccion";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Location = new System.Drawing.Point(12, 103);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(193, 55);
            this.btnGenerarXml.TabIndex = 2;
            this.btnGenerarXml.Text = "Generar archivo xml";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // FrmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 312);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.rtbListarProduccion);
            this.Name = "FrmFabrica";
            this.Text = "Estado de fabrica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListarProduccion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGenerarXml;
    }
}