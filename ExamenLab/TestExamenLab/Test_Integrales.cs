using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenLab.Integrales;

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
            Potencia integral = new Potencia(1, 2, 3);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 3.75;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralLogaritmo()
        {
            Logaritmo integral = new Logaritmo(1, 2);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 0.693147180559945;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralExponencial()
        {
            Exponencial integral = new Exponencial(1, 2);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 4.670774270416;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralSeno()
        {
            Seno integral = new Seno(5, 10);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 1.12273371453968;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }

        [TestMethod]
        public void IntegralCoseno()
        {
            Coseno integral = new Coseno(5, 10);
            double realResult = integral.ObtenerSolucion();
            double expectedResult = 0.414903163773769;
            Assert.IsTrue(realResult == expectedResult, string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedResult, realResult));
        }
    }
}
