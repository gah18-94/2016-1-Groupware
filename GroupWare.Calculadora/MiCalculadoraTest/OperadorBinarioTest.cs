using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadoraTest
{
    [TestClass]
    public class TestSuma
    {
        [TestMethod]
        public void SumarDosMasDos()
        {
            String operador = "+";
            double operando1 = 2;
            double operando2 = 2;
            double resultadoEsperado = 4;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2),resultadoEsperado);

        }

        [TestMethod]
        public void SumarDiezMasCero()
        {
            String operador = "+";
            double operando1 = 10;
            double operando2 = 0;
            double resultadoEsperado = 10;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2), resultadoEsperado);

        }
    }
}
