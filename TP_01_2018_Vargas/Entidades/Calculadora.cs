using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar( Numero numeroUno, Numero numeroDos, string operador)
        {
            double retorno = 0;
            string retornoOperador = ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    retorno = numeroUno + numeroDos;
                    break;
                case "-":
                    retorno = numeroUno - numeroDos;
                    break;
                case "*":
                    retorno = numeroUno * numeroDos;
                    break;
                case "/":
                    if (numeroUno != 0)
                    {
                        retorno = numeroUno / numeroDos;
                    }
                    break;
            }
            return retorno;

        }
        private static string ValidarOperador( string operador)
        {
            string retorno = "";
            
            switch (operador)
            {
                case "+":
                    retorno = "+";
                    return retorno;
                    break;
                case "-":
                    retorno = "-";
                    return retorno;
                    break;
                case "*":
                    retorno = "*";
                    return retorno;
                    break;
                case "/":
                    retorno = "/";
                    return retorno;
                    break;
                default:
                    retorno = "+";
                    break;
            }
            return retorno;
        }



    }
}
