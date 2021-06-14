using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MenuFabricacion
{
    public partial class FrmControlStock : Form
    {
        private Fabrica fabrica;
        public FrmControlStock(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        private void btnGenerarTxt_Click(object sender, EventArgs e)
        {
            Archivadora.EscribirTxt(@"..\..\..\Archivos\Stock Actual.txt", this.fabrica.ListarStockFabrica());
            MessageBox.Show("Se genero el archivo");
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            int micro;
            int memoria;
            int almacenamiento;
            int placa;

            if (int.TryParse(this.txtMicro.Text, out micro) &&
                    int.TryParse(this.txtRam.Text, out memoria) &&
                    int.TryParse(this.txtAlmacenamiento.Text, out almacenamiento) &&
                    int.TryParse(this.txtPlaca.Text, out placa))
            {
                fabrica.CantMicro += micro;
                fabrica.CantMemoria += memoria;
                fabrica.CantAlmacenamiento += almacenamiento;
                fabrica.CantPlacaMadre += placa;
            }
            else
            {
                throw new StockException("Valores de ingreso de stock invalidos", "FrmConstrolStock", "btnAgregarStock_Click");
            }
        }
    }
}
