using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadoraTest
{
    /// <summary>
    /// Summary description for TestResta
    /// </summary>
    [TestClass]
    public class TestResta
    {

        const string miOperador = "-";
        double miOperandoUno;
        double miOperandoDos;
        double miResultadoEsperado;
        double miResultadoReal;
        Groupware.Calculadora.MiCalculadora invocador =
                new Groupware.Calculadora.MiCalculadora();

        [TestMethod]
        public void RestarDiezMenosDos()
        {
            // prepare el escenario
            miOperandoUno = 10;
            miOperandoDos = 2;
            miResultadoEsperado = 8;

            // realice la invocación al método
            miResultadoReal = invocador.OperadorBinario(miOperador,
                miOperandoUno, miOperandoDos);

            // realice la verificación de si el cálculo es correcto
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }


        public void DiezMenosCinco()
        {
            // prepare el escenario
            miOperandoUno = 10;
            miOperandoDos = 5;
            miResultadoEsperado = 5;

            // realice la invocación al método
            miResultadoReal = invocador.OperadorBinario(miOperador,
                miOperandoUno, miOperandoDos);

            // realice la verificación de si el cálculo es correcto
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }
    }
}
