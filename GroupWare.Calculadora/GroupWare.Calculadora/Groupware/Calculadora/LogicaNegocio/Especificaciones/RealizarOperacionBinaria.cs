using Groupware.Calculadora.LogicaNegocio.Enumerados;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    internal class RealizarOperacionBinaria
    {
        private Operadores miOperador;
        private double operandoDos;
        private double operandoUno;

        public double RealizarLaOperacionBinaria(Operadores miOperador, double operandoUno, double operandoDos)
        {
            double resultado = 0.0;
            switch (miOperador)
            {
                case Enumerados.Operadores.Suma:
                    var laSuma = new LogicaNegocio.Especificaciones.Suma();
                    resultado = laSuma.Calculo(operandoUno, operandoDos);
                    break;
                case Enumerados.Operadores.Division:
                    var division = new LogicaNegocio.Especificaciones.Division();
                    resultado = division.Calculo(operandoUno, operandoDos);
                    break;
                case Enumerados.Operadores.Multiplicacion:
                    var multiplicacion = new LogicaNegocio.Especificaciones.Multiplicacion();
                    resultado = multiplicacion.Calculo(operandoUno, operandoDos);
                    break;
                case Enumerados.Operadores.Resta:
                    var resta = new LogicaNegocio.Especificaciones.Resta();
                    resultado = resta.Calculo(operandoUno, operandoDos);
                    break;

            }
            return (resultado);

        }
    }
}