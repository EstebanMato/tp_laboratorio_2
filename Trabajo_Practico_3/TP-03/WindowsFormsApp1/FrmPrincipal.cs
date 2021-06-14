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

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Fabrica f = new Fabrica();

            Telefono t1 = new Telefono("S8 plus", 64, Producto.EGama.ALTA);
            Telefono t2 = new Telefono("J7", 128, Producto.EGama.BAJA);

            Notebook n1 = new Notebook("HP", 64);
            Notebook n2 = new Notebook("SAMSUNG", 128);

            f += t1;
            f += t2;
            f += n1;
            f += n2;

            rtbFabricacion.Text = f.ListarProducion();
        }
    }
}
