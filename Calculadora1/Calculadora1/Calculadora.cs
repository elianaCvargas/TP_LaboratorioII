using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Calculadora
    {

         public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            if (operador == "+")
            {
                double suma = Convert.ToDouble(numero1 + numero2);
                return suma;
            }
            if (operador == "-")
            {
                double resta = Convert.ToDouble(numero1 - numero2);
                return resta;
            }
            if (operador == "*")
            {
                double multiplicacion = Convert.ToDouble(numero1 * numero2);
                return multiplicacion;
            }
            if (operador == "/")
            {
                if (numero2 != 0)
                {
                    double division = Convert.ToDouble(numero1 / numero2);
                    return division;
                }
                return 0;

            }
            return -1;
 
        }
        public static string ValidarOperador(string operador)
        { 
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }        
            return "+";        
        }


    }
}
