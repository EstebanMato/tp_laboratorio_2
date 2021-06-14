using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la fabrica con cero unidades de stock
            Fabrica f = new Fabrica(1000, 1000, 10000, 100);

            //Al querer agregar una notebook salta la excepcion de sin stock
            //Notebook n1 = new Notebook("SAMSUNG", 1, 16, 1000, 1,Producto.EGama.ALTA);

            //Agregamos stock
            //f.AgregarStock(1000, 1000, 10000, 100);
            Console.WriteLine(f.ListarStockFabrica());

            //agregamos una notebook
            Notebook n1 = new Notebook("SAMSUNG", 1, 16, 1000, 1,Producto.EGama.ALTA);
            f += n1;

            //Listamos el stock actual
            Console.WriteLine(f.ListarStockFabrica());
            //agregamos otra
            Notebook n2 = new Notebook("HP", 1, 32, 1000, 1, Producto.EGama.BAJA);
            f += n2;

            Notebook n3 = new Notebook("Banghoo", 1, 8, 500, 1, Producto.EGama.BAJA);
            Notebook n4 = new Notebook("MAC", 2, 32, 2000, 1, Producto.EGama.ALTA);
            f += n3;
            f += n4;
            Console.WriteLine("Despues de cargar 4 notebook listamos el stock\n");
            Console.WriteLine(f.ListarStockFabrica());
            Console.WriteLine("Listamos produccion\n");
            Console.WriteLine("-----------\n");
            Console.WriteLine(f.ListarProducion());
            //Guardamos en el archivo txt los datos de n1
            Archivadora.EscribirTxt(@"..\..\..\Archivos\Fabricado.txt", n1.Mostrar());
            Console.WriteLine("Guardamos el stock actual en formato txt");
            Archivadora.EscribirTxt(@"..\..\..\Archivos\StockActual.txt", f.ListarStockFabrica());

            //Mostramos lo guardado anteriormente
            Console.WriteLine(Archivadora.LeerTxt(@"..\..\..\Archivos\StockActual.txt"));

            //Guardamos en xml lo producido hasta ahora
            Archivadora.SerializarXml<List<Producto>>(f.ListaDeProductos, @"..\..\..\Archivos\ListaDeProductos.xml");
            Console.ReadKey();
        }
    }
}
