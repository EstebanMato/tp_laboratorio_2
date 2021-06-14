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
    public partial class FrmCrearProducto : Form
    {
        private Fabrica f;
        public FrmCrearProducto(Fabrica f)
        {
            InitializeComponent();
            this.f=f;
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Notebook notebook;
            if (rbtnSamsung.Checked == true)
            {
                notebook = new Notebook("SAMSUNG", 1, 16, 1000, 1,Producto.EGama.ALTA);
                f += notebook;
            }
            if (rbtnBangho.Checked == true)
            {
                notebook = new Notebook("Banghoo", 1, 8, 500, 1,Producto.EGama.BAJA);
                f += notebook;
            }
            if (rbtnMAC.Checked == true)
            {
                notebook = new Notebook("MAC", 2, 32, 2000, 1, Producto.EGama.ALTA);
                f += notebook;
            }
            if (rbtnHP.Checked == true)
            {
                notebook = new Notebook("HP", 1, 32, 1000, 1, Producto.EGama.BAJA);
                f += notebook;
            }

            MessageBox.Show("Se fabrico el producto!");
        }
    }
}
