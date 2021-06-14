using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Excepciones: 
    //Se controlaron las posibles excepciones que pudiera tener la aplicación.
    //Se crearon 2 clases de excepciones “FabricaException” y “StockException” donde se contralará la falla en caso de que se intente fabricar un producto sin stock y que no sean ingresados valores para sumar al stock inválidos los cuales pudieran llegar a hacer fallar la aplicación.

    public class FabricaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
            set
            {
                this.nombreClase = value;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }

            set
            {
                this.nombreMetodo = value;
            }
        }

        public FabricaException(string mensaje, string clase, string metodo)
            :base(mensaje)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;

        }

        public FabricaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje,innerException)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;

        }
    }
}
