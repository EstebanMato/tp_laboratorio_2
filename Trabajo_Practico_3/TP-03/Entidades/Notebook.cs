using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;



namespace Entidades
{
    /// <summary>
    /// Interfaces:
    /// Dentro de la clase IInformación se encuentra 
    /// la única interfaz implementada en la aplicación la cual es usada por la clase Notebook
    /// </summary>
    [Serializable]
    public class Notebook : Producto, IInformacion
    {
        public int microprocesador;
        public int memoriaRam;
        public int almacenamiento;
        public int placaMadre;

        /// <summary>
        /// Constructor por defecto de Notebook
        /// </summary>
        public Notebook()
        {

        }

        /// <summary>
        /// Constructor que genere una notebook con los datos recibidos como parametro
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="micropocesador"></param>
        /// <param name="memoriaRam"></param>
        /// <param name="almacenamiento"></param>
        /// <param name="placaMadre"></param>
        /// <param name="gama"></param>
        public Notebook(string modelo, int micropocesador, int memoriaRam, int almacenamiento, int placaMadre, EGama gama)
            : base(modelo, gama)
        {
            this.Microprocesador = micropocesador;
            this.MemoriaRam = memoriaRam;
            this.Almacenamiento = almacenamiento;
            this.PlacaMadre = placaMadre;

        }

        /// <summary>
        /// propiedad que retorna la cantidad de microprosesadores asignada
        /// </summary>
        public int Microprocesador
        {
            get
            {
                return this.microprocesador;
            }

            set
            {
                this.microprocesador = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la cantidad de memoria ram asignada
        /// </summary>
        public int MemoriaRam
        {
            get
            {
                return this.memoriaRam;
            }

            set
            {
                this.memoriaRam = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la cantidad e almacenamiento asignada
        /// </summary>
        public int Almacenamiento
        {
            get
            {
                return this.almacenamiento;
            }

            set
            {
                this.almacenamiento = value;
            }
        }

        /// <summary>
        /// propiedad que retorna la cantidad de la placa madre asignada
        /// </summary>
        public int PlacaMadre
        {
            get
            {
                return this.placaMadre;
            }

            set
            {
                this.placaMadre = value;
            }
        }


        /// <summary>
        /// Propiedad que retorna la informacion de una notebook 
        /// </summary>
        /// <returns>Retorna en formato string</returns>
        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de procesadores{this.microprocesador}");
            sb.AppendLine($"Cantidad de memoria RAM {this.memoriaRam}");
            sb.AppendLine($"Cantidad de almacenamiento {this.almacenamiento}");
            sb.AppendLine($"Cantidad de placa madre {this.placaMadre}");
            return sb.ToString();
        }

        /// <summary>
        /// Propiedad que retorna la informacion de un producto
        /// </summary>
        /// <returns>Retorna todos los datos en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine(this.MostrarInformacion());
            sb.AppendLine("------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Propiedad que valida que haya stock suficiente segun el producto
        /// </summary>
        /// <param name="f"></param>
        /// <returns>Retorna true si pudo descontar, false en caso contrario</returns>
        public override bool EnsambladoProductos(Fabrica f)
        {
            bool returnAux = false;
            if((f.CantMicro - this.microprocesador)>0 &&
                    (f.CantPlacaMadre - this.placaMadre) > 0 &&
                      (f.cantAlmacenamiento - this.almacenamiento) > 0 &&
                      (f.CantMemoria - this.memoriaRam) > 0)
            {
                f.CantMicro = - this.microprocesador;
                f.CantAlmacenamiento = - this.almacenamiento;
                f.CantPlacaMadre = - this.placaMadre;
                f.CantMemoria = - this.memoriaRam;

                returnAux = true;
            }
            return returnAux;
        }
    }
}
