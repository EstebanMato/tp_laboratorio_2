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

            Fabrica f = new Fabrica(100, -10, 100, 100);

            Notebook n1 = new Notebook("SAMSUNG", 1, 16, 1000, 1,Producto.EGama.ALTA);
            Notebook n2 = new Notebook("HP", 1, 32, 1000, 1, Producto.EGama.BAJA);

            Console.WriteLine(f.ListarStockFabrica());
            f += n1;
            f += n2;
            Console.WriteLine(f.ListarStockFabrica());

            Console.WriteLine(f.ListarProducion());
            Archivadora.EscribirTxt(@"..\..\..\Archivos\Fabricado.txt", n1.Mostrar());
            Archivadora.EscribirTxt(@"..\..\..\Archivos\Fabricado.txt", n2.Mostrar());

            Console.WriteLine(Archivadora.LeerTxt(@"..\..\..\Archivos\stock.txt"));
            
            Archivadora.SerializarXml<List<Producto>>(f.ListaDeProductos, @"..\..\..\Archivos\ListaDeProductos.xml");
            
            
           

        }
    }
}
