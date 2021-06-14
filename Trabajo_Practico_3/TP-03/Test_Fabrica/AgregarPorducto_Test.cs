using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_Fabrica
{
    //Se testearon 2 funcionalidades, que la iniciación de la lista de productos sea correcta
    //y que al agregar un nuevo producto las validaciones sean las necesarias
    //para que no llegue ningún dato mal cargado.
    [TestClass]
    public class AgregarPorducto_Test
    {
        [TestMethod]
        public void AgregarProducto_True()
        {
            //ARRANGE - Parametros de inicio
            Fabrica fabrica = new Fabrica(1000, 1000, 10303, 1000);
            Notebook notebook = new Notebook("HP", 1, 32, 100, 1, Producto.EGama.BAJA);
            bool resultado;
            // bool resultado;
            //ACT - Llamada al metodo a testear
            resultado = fabrica.AgregarProducto(notebook);
            //ASSERT - Comportamiento esperado
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void AgregarProducto_False()
        {
            //ARRANGE - Parametros de inicio
            Fabrica fabrica = new Fabrica(0, 0, 0, 0);
            Notebook notebook = new Notebook("BANGHOO", 1, 8, 500, 1, Producto.EGama.BAJA);
            bool resultado;
            // bool resultado;
            //ACT - Llamada al metodo a testear
            resultado = fabrica.AgregarProducto(notebook);
            //ASSERT - Comportamiento esperado
            Assert.IsFalse(resultado);

            //ARRANGE - Parametros de inicio
            
            //ACT - Llamada al metodo a testear
            resultado = fabrica.AgregarProducto(null);
            //ASSERT - Comportamiento esperado
            Assert.IsFalse(resultado);
        }
    }
}
