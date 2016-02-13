using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    public class Division
    {
        public double Calculo (double operandoUno, double operandoDos)
        {
            double resultado;
            // invoque a la acción correspondiente
            Acciones.Dividir operacion = new Acciones.Dividir();
            resultado = operacion.Calcular(operandoUno, operandoDos);

            return (resultado);

        }
    }
}