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
            LiteralController literalController = LiteralController();
            int a= 4;
            string esperado = "CUATRO";
            //Act
            string resultado = literalController.Lit(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        private LiteralController LiteralController()
        {
            throw new NotImplementedException();
        }
    }
}
