using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Utilice genéricos al momento de serializar y deserializar, dentro de la clase “Archivadora”, 
    /// haciendo la serialización xml genérica. 
    /// La clase “Archivadora” contiene una escritura y lectura en formato txt, 
    /// y la serializacion y deserealización de la información en formato xml
    /// </summary>
    public static class Archivadora 
    {
        /// <summary>
        /// Crea un archivo txt segun la ruta y los datos pasados como parametros
        /// </summary>
        /// <param name="path">Ruta dodne escribir</param>
        /// <param name="datos">Datos a escribir</param>
        /// <returns></returns>
        public static bool EscribirTxt(string path, string datos)
        {
            bool returnAux = false;
            StreamWriter escribir = new StreamWriter(path);

            using (escribir)
            {
                escribir.WriteLine(datos);
                if (File.Exists(path))
                    returnAux = true;
            }
            return returnAux;
        }

        /// <summary>
        /// Lee el archivo txt segun la ruta pasada como parametro
        /// </summary>
        /// <param name="path">ruta del archivo txt</param>
        /// <returns>Retorna lo que pudo leer, caso contrario vacio en formato string</returns>
        public static string LeerTxt(string path)
        {
            string texto = "";

            if(File.Exists(path))
            {
                StreamReader leer = new StreamReader(path);
                texto += leer.ReadToEnd();

            }

            return texto;
        }

        
        /// <summary>
        /// Serializador genérico donde recibe un objeto no importa el tipo y lo serializa en formato xml
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="objeto">obejot</param>
        /// <param name="path">ruta donde guarda</param>
        /// <returns></returns>
        public static bool SerializarXml<T>(T objeto, string path)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);
            bool returnAux = true;
            using(escritor)
            {
                try
                {
                    serializador.Serialize(escritor, objeto);
                }
                catch
                {
                    //aca podriamos lanzar otra excepcion
                    returnAux = false;
                }
            }

            return returnAux;
        }

        /// <summary>
        /// Deserializador genérico donde recibe un objeto no importa el tipo y lo desserializa desde un formato xml
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="objeto">objeto</param>
        /// <param name="path">ruta del archivo</param>
        /// <returns></returns>
        public static T DeserializarXml<T>(T objeto, string path)
        {
            if(!File.Exists(path))
                return default;

            XmlTextReader lector = new XmlTextReader(path);
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            T returnAux = default(T);

            using(lector)
            {
                try
                {
                    returnAux = (T)serializador.Deserialize(lector);
                }
                catch
                {
                    return default;
                }             
            }
            return returnAux;
        }
    }

}
