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
    public partial class FrmFabrica : Form
    {
        private Fabrica fabrica;
        public FrmFabrica(Fabrica f)
        {
            InitializeComponent();
            this.fabrica = f;
        }

        private void btnListar_Click(object sender, EventArgs e)
        { 
            rtbListarProduccion.Text = this.fabrica.ListarProducion();
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            Archivadora.SerializarXml<List<Producto>>(this.fabrica.ListaDeProductos, @"..\..\..\Archivos\ListaDeProductos.xml");
            MessageBox.Show("Se genero el archivo");
        }
    }
}
