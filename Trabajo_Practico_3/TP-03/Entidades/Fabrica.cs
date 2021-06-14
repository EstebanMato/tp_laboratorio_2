using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    [Serializable]
    public class Fabrica
    {
        private List<Producto> listaDeProductos;
        public int cantMicro;
        public int cantMemoria;
        public int cantAlmacenamiento;
        public int cantPlacaMadre;

        /// <summary>
        /// Constructor que instancia la fabrica
        /// </summary>
        public Fabrica()
        {
            this.listaDeProductos = new List<Producto>();
        }
        /// <summary>
        /// Constructor que crea la fabrica llamada al constructor por defecto y pasando los datos a la base 
        /// </summary>
        /// <param name="micro"></param>
        /// <param name="memoria"></param>
        /// <param name="almacenamiento"></param>
        /// <param name="madre"></param>
        public Fabrica(int micro, int memoria, int almacenamiento, int madre)
           : this()
        {
            this.CantMicro = micro;
            this.CantMemoria = memoria;
            this.CantAlmacenamiento = almacenamiento;
            this.CantPlacaMadre = madre;
        }

        /// <summary>
        /// Propiedad que retorna la ListaDeProductos
        /// </summary>
        public List<Producto> ListaDeProductos
        {
            get
            {
                return this.listaDeProductos;
            }

            set
            {
                this.listaDeProductos = value;
            }
        }
        
        /// <summary>
        /// Propiedad que retorna la cantidad de microprocesadores
        /// </summary>
        public int CantMicro
        {
            get
            {
                return this.cantMicro;
            }
            set
            {
                this.cantMicro += value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la cantidad de memoria Ram
        /// </summary>
        public int CantMemoria
        {
            get
            {
                return this.cantMemoria;
            }
            set
            {
                this.cantMemoria += value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la cantidad de almacenamiento
        /// </summary>
        public int CantAlmacenamiento
        {
            get
            {
                return this.cantAlmacenamiento;
            }
            set
            {
                this.cantAlmacenamiento += value;
            }
       
        }

        /// <summary>
        /// propiedad que retorna la cantidad de placas madres
        /// </summary>
        public int CantPlacaMadre
        {
            get
            {
                return this.cantPlacaMadre;
            }
            set
            {
                this.cantPlacaMadre += value;
            }
        }

        /// <summary>
        /// Propiedad que agrega un producto a la lista previa validacion
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool AgregarProducto(Producto producto)
        {
            bool returnAux = false;
            if(producto.EnsambladoProductos(this))
            {
                this.listaDeProductos.Add(producto);
                returnAux = true;
            }
            return returnAux;
        }

        /// <summary>
        /// Propiedad que lista los productos ya fabricados
        /// </summary>
        /// <returns>Lista de productos en string</returns>
        public string ListarProducion()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in this.ListaDeProductos)
            {
                sb.AppendLine(p.Mostrar());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un producto a la lista de fabricados previa validacion
        /// </summary>
        /// <param name="f"></param>
        /// <param name="p"></param>
        /// <returns>Retorna la fabrica</returns>
        public static Fabrica operator +(Fabrica f, Producto p)
        {      
            if (!(f.AgregarProducto(p)))
            {
                throw new FabricaException("Sin stock para fabricacion", "Fabrica", "Fabricar producto");
            }

            return f;
        }

        /// <summary>
        /// Lista el stock restante
        /// </summary>
        /// <returns>Stock restante en string</returns>
        public string ListarStockFabrica()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de micros {this.CantMicro} \nCantidad de RAM {this.CantMemoria}\nCantida de HDD {this.CantAlmacenamiento}\nCantidad mother {this.cantPlacaMadre}");
            return sb.ToString();
        }
    }

}
