using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar( Numero numeroUno, Numero numeroDos, String operador)
        {
            double retorno = 0;
            string retornoOperador = ValidarOperador(operador);
            switch (retornoOperador)
            { 
                case "+":
                   // retorno = Convert.ToDouble(numeroUno + numeroDos);
                    break;
            }

            return retorno;
                  
        }
        private static string ValidarOperador( String operador)
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
