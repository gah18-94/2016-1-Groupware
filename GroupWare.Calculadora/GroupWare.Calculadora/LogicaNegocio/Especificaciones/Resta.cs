using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{

    public class Resta
    {
        public double Calculo(double operandoUno, double operandoDos)
        {
            double resultado;
            // invoque a la acción correspondiente
            Acciones.Restar operacion = new Acciones.Restar();
            resultado = operacion.Calcular(operandoUno, operandoDos);

            return (resultado);

        }
    }

}