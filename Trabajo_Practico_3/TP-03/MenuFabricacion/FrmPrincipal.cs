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
    public partial class FrmPrincipal : Form
    {
        private FrmControlStock controlStock;
        private FrmFabrica listarFabrica;
        private FrmCrearProducto crearProducto;
        private Fabrica fabrica;
        public FrmPrincipal()
        {
            InitializeComponent();
            fabrica = new Fabrica(100,500,10000,100);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFabricarProducto_Click(object sender, EventArgs e)
        {
            crearProducto = new FrmCrearProducto(fabrica);
            crearProducto.ShowDialog();
        }

        private void btnListarProduccion_Click(object sender, EventArgs e)
        {
            listarFabrica = new FrmFabrica(fabrica);
            listarFabrica.ShowDialog();

        }

        private void btnControlStock_Click(object sender, EventArgs e)
        {
            controlStock = new FrmControlStock(fabrica);
            controlStock.ShowDialog();
        }
    }
}
