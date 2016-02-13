using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadoraTest
{
    [TestClass]
    public class TestDividir
    {
        [TestMethod]
        public void dividirDosYDos()
        {
            String operador = "/";
            double operando1 = 2;
            double operando2 = 2;
            double resultadoEsperado = 1;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2), resultadoEsperado);

        }
    }
}
