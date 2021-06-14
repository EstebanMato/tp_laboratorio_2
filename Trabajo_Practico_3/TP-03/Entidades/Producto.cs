using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Notebook))]
    public abstract class Producto
    {
        protected string modelo;
        protected EGama gama;

        /// <summary>
        /// Enum con las dos posibles tipo de gama
        /// </summary>
        public enum EGama { ALTA, BAJA};

        /// <summary>
        /// Constructor publico por defecto
        /// </summary>
        public Producto()
        {

        }

        /// <summary>
        /// Constructor que instancia un producto segun lo pasado por parametro
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="gama"></param>
        public Producto(string modelo, EGama gama)
        {
            this.modelo = modelo;
            this.gama = gama;
        }

        /// <summary>
        /// Propiedad que retorna el modelo de un prodcuto
        /// </summary>
        public string Modelo
        {
            get
            {
                return this.modelo;
            }

            set
            {
                this.modelo = value;
            }
        }

        /// <summary>
        /// propiedad que retorna la gama de un producto
        /// </summary>
        public EGama Gama
        {
            get
            {
                return this.gama;
            }
            set
            {
                this.gama = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la informacion de un producto
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El modelo fabricado es: {this.Modelo}");

            return sb.ToString();
        }

        public abstract bool EnsambladoProductos(Fabrica f);

        
    }
}
