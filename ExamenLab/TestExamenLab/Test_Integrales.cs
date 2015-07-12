using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestExamenLab
{
    [TestClass]
    public class Test_Integrales
    {
        [TestMethod]
        public void IntegralSimple()
        {
            Simple integral = new Simple(5, 10);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 5;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " + 
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralConstante()
        {
            Constante integral = new Constante(5, 10, 2);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 10;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralPotencia()
        {
            Potencia integral = new Potencia(5, 10, 2);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 10;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }
    }
}
