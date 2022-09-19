using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class LogicTest
    {

        [TestMethod]
        public void DividirTest_DividirEnteros_DeberiaRetornarResultadoEsperado()
        {
            //Arrange
            decimal dividendo = 10;
            decimal divisor = 2;
            decimal resultadoEsperado =5;
            decimal resultadoReal;

            //Act
            resultadoReal = Logic.Dividir(dividendo,divisor);

            //Assert
            Assert.AreEqual(resultadoReal, resultadoEsperado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirTest_DividirPorCero_DeberiaLanzarUnaExcepcion()
        {
            //Arrange
            decimal dividendo = 10;
            decimal divisor = 0;
            decimal resultadoReal;

            //Act
            resultadoReal = Logic.Dividir(dividendo, divisor);
        }

        [TestMethod]
        [DataRow(4.5,3,1.5)]
        [DataRow(-20,2,-10)]
        [DataRow(15,15,1)]
        public void DividirTest_DiferenteTiposDeNumeros_DeberiaRetornarResultadoEsperado(double dividendoEnDouble, double divisorEnDouble, double resultadoEsperadoEnDouble)
        {
            //Act
            decimal dividendo = Convert.ToDecimal(dividendoEnDouble);
            decimal divisor = Convert.ToDecimal(divisorEnDouble);
            decimal resultadoEsperado = Convert.ToDecimal(resultadoEsperadoEnDouble);
            
            decimal resultadoReal = Logic.Dividir(dividendo, divisor);

            //Assert
            Assert.AreEqual(resultadoReal, resultadoEsperado);
        }
    }
}
