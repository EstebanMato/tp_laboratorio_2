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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        bool flagBinario = false;
        bool flagDecimal = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierre del programa, previa confirmación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte a binario del resultado, previa validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            if(!flagBinario && lblResultado.Text != string.Empty)
            {
                lblResultado.Text = num1.DecimalBinario(lblResultado.Text);
                flagBinario = true;
                flagDecimal = false;
            }
        }

        /// <summary>
        /// Convierte a decimal del resultado, previa validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            if(!flagDecimal && lblResultado.Text != string.Empty)
            {
                lblResultado.Text = num1.BinarioDecimal(lblResultado.Text);
                flagBinario = false;
                flagDecimal = true;
            }
                    }

        /// <summary>
        /// Llama a la funcion this.Limpiar();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Opera entre los dos números segun el signo, previa validación de datos y muestra el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double n1;
            double n2;

            if (!(String.IsNullOrEmpty(txtNumero1.Text)) &&
                !(String.IsNullOrEmpty(txtNumero2.Text)) && 
                !(String.IsNullOrEmpty(cmbOperador.Text)))
            {
                if(double.TryParse(txtNumero1.Text, out n1) &&
                double.TryParse(txtNumero2.Text, out n2))
                {
                    resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

                    if (resultado == double.MinValue)
                    {
                        lblResultado.Text = "No es posible la division por 0";
                    }
                    else
                    {
                        lblResultado.Text = resultado.ToString();
                        flagBinario = false;
                        flagDecimal = false;
                    }
                }
                else
                {
                    lblResultado.Text = "Formato invalido de los operandos";
                }
                
            }
            else
            {
                lblResultado.Text = "Faltan datos para operar";
            }
        }

        /// <summary>
        /// Borra los valores en pantalla seteando en 0 o Empty o false los valores
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = string.Empty;
            txtNumero1.Text = string.Empty;
            cmbOperador.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            flagBinario = false;
            flagDecimal = false;
        }

        /// <summary>
        /// Opera los 2 numero segun el operador
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar (string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            
            return Calculadora.Operar(num1, num2, operador);
        }

    }
}
