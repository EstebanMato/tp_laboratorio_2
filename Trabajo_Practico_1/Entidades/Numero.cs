using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        //ATRIBUTO
        private double numero;

        /// <summary>
        /// Constructor por defecto de Numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Set el valor en el objeto
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        /// <summary>
        /// Set el valor en el objeto usando el formato especificado
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
          : this(numero.ToString())
        {
           
        }

        /// <summary>
        /// Set el valor en el objeto usando el formato especificado
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Pasa un número binario entero positivo a formato decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>String del número resultante; "Valor inválido" en caso contrario</returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int valor = 0;
                string binarioFinal = "";
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    binarioFinal += binario[i];
                }

                for (int i = 0; i < binarioFinal.Length; i++)
                {
                    if (binarioFinal[i] == '1')
                    {
                        valor += (int)Math.Pow(2, i);
                    }
                }
                return valor.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Pasa un número decimal entero positivo a formato binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>String del número resultante; "Valor inválido" en caso contrario  </returns>
        public string DecimalBinario(double numero)
        {
            StringBuilder binarioInvertido = new StringBuilder();
            int resto = 0;
            if (!double.IsNaN(numero))
            {
                numero = (int)Math.Abs(numero);

                while (numero >= 2)
                {
                    resto = (int)numero % 2;
                    binarioInvertido.Append(resto.ToString());
                    numero /= 2;
                }
                if (numero == 0)
                    binarioInvertido.Append("0");
                else
                    binarioInvertido.Append("1");
 
                StringBuilder binario= new StringBuilder();

                for (int i = binarioInvertido.Length; i > 0; i--)
                {
                    binario.Append(binarioInvertido[i - 1]);
                }
                return binario.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Valida que el string recibido sea un numero y realiza la conversión a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>String del número resultante; "Valor inválido" en caso contrario</returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double dNumero))
                return this.DecimalBinario(dNumero);
            return "Valor inválido";
        }

        /// <summary>
        /// Valida que el string recibido sea binario, solo 1 y 0 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True o false</returns>
        private bool EsBinario(string binario)
        {
            foreach (char numero in binario)
            {
                if (numero != '0' && numero != '1')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que el string recibido sea un numero 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>strNumero si es un numero; en caso contrario 0 </returns>
        private double ValidarNumero(string strNumero)
        {

            if (double.TryParse(strNumero, out double numeroRetorno))
            {
                return numeroRetorno;
            }

            return 0;
        }

        /// <summary>
        /// Realiza la resta entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Valor resultante</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Realiza el producto entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Valor resultante</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza la division entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Valor resultante en caso de que n2 sea distinto de 0; caso contrario "MinValue"</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Realiza la suma entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Valor resultante</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
