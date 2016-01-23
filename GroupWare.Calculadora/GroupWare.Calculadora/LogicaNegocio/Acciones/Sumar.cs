using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupWare.Calculadora.LogicaNegocio.Acciones
{
    public class Sumar
    {
        public double Calcular (double operandoUno, double operandoDos) {
            double resultado = operandoUno + operandoDos;
            return resultado;
        }
    }
}