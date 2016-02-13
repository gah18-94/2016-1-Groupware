using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Acciones
{
    public class Multiplicar
    {
        public double Calcular(double operandoUno, double operandoDos)
        {
            if (operandoUno >= 0 & operandoDos >= 0)
            {
                double resultado = operandoUno * operandoDos;
                return resultado;
            }

            else {
                Console.WriteLine("Los operadores deben de ser mayor que cero.");
                return -1;
            } 
           
        }
    }
}