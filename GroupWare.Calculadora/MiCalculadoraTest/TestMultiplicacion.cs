using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadoraTest
{
    [TestClass]
    public class TestMultiplicacion
    {
        [TestMethod]
        public void multiplicarDosyDos()
        {
            String operador = "*";
            double operando1 = 2;
            double operando2 = 2;
            double resultadoEsperado = 4;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2), resultadoEsperado);

        }

        [TestMethod]
        public void multiplicarDosyCero()
        {
            String operador = "*";
            double operando1 = 2;
            double operando2 = 0;
            double resultadoEsperado = 0;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2), resultadoEsperado);

        }

        [TestMethod]
        public void multiplicarDosyMenosUno()
        {
            String operador = "*";
            double operando1 = 2;
            double operando2 = -1;
            double resultadoEsperado = -1;

            var invocador = new Groupware.Calculadora.MiCalculadora();

            Assert.AreEqual(invocador.OperadorBinario(operador, operando1, operando2), resultadoEsperado);

        }
    }
}
