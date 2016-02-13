using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Acciones
{

    public class Restar
    {
        public double Calcular(double operandoUno, double operandoDos)
        {
            double resultado = operandoUno - operandoDos;

            return resultado;
        }
    }

}