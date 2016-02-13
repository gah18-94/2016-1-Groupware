using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    public class Multiplicacion
    {
        public double Calculo(double operandoUno, double operandoDos)
        {
            double resultado;
            // invoque a la acción correspondiente
            Acciones.Multiplicar operacion = new Acciones.Multiplicar();
            resultado = operacion.Calcular(operandoUno, operandoDos);

            return (resultado);

        }
    }
}