﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre num1 y num2 segun el valor de operador previa validación 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>La operacion realizada; Caso contrario la suma de ambos</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(Convert.ToChar(operador));

            switch (operador)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "/":
                    return num1 / num2;

                case "*":
                    return num1 * num2;

                default:
                    return num1 + num2;
            }
        }

        /// <summary>
        /// Valida que el operador sea + - / *
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador en caso de ser correcto; + caso contrario</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
                return char.ToString(operador);

            return "+";
        }
    }
}
