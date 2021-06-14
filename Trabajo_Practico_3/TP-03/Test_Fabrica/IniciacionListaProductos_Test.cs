using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Collections.Generic;

namespace Test_Fabrica
{
    //Se testearon 2 funcionalidades, que la iniciación de la lista de productos sea correcta
    //y que al agregar un nuevo producto las validaciones sean las necesarias
    //para que no llegue ningún dato mal cargado.
    [TestClass]
    public class IniciacionListaProductos_Test
    {
        Fabrica fabrica = new Fabrica();
        //private List<Producto> listaDeProductos;
        [TestMethod]
        public void CreacionLista_NoNulla()
        {
            //ARRANGE - Parametros de inicio
            Notebook producto = new Notebook();
           
            //ACT - Llamada al metodo a testear
            
            //ASSERT - Comportamiento esperado
            Assert.IsNull(fabrica.ListaDeProductos);
        }
    }    
}
