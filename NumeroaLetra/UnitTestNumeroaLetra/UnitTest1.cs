using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroaLetra.Controllers;
using System;

namespace UnitTestNumeroaLetra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Literal()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int a= 4;
            string esperado = "CUATRO  00 /100";

            //Act
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        
    }
}
