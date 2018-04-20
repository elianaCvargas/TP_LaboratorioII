using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero() { }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        public string SetNumero {
            set {
                //La propiedad SetNumero asignará un valor al atributo numero, previa validación.
                //En este lugar será el único en todo el código que llame al método ValidarNumero.
                double numeroDoble = ValidarNumero(value);
                if (numeroDoble != 0)
                {
                    this.numero = numeroDoble;
                }

            }
        }


            public string BinarioDecimal(string binario) 
            {
                //NOTA:  Al ingresar la cadena, debe tener si o si tanto 0 como 1 sino tira error
                //significa que si o si debe ir un 0 acompañado de uno
                string retorno = "";
                int lenBinario = binario.Length;
                double aux = 0;
                double auxFinal = 0;          
                int posicion = 0;
                int i = 0;
                if (binario.Contains("0") && binario.Contains("1"))
                {
                    for (i = binario.Length; i >= 0; i--)
                    {

                        posicion = lenBinario - i;
                        if (posicion != lenBinario)
                        {
                            if (binario[posicion] == '1')
                            {
                                posicion--;
                                aux = Math.Pow(2, i - 1);
                                auxFinal = auxFinal + aux;
                                continue;

                            }
                        }
                    }
                    retorno = Convert.ToString(auxFinal);
                    return retorno;
                }
                else {
                    retorno = "Valor inválido";
                    return retorno;
                }
        
            }


    
        
        public string DecimalBinario(double numero)
        {
            int numeroInt = Convert.ToInt32(numero);
            string binario = Convert.ToString(numeroInt, 2);
            return binario;

        }
        public string DecimalBinario(string numero)
        {
            double numDoble = Convert.ToDouble(numero);
            return DecimalBinario(numDoble);

        }
        public double ValidarNumero(string numero)
        { 
//            ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
//            formato double. Caso contrario, retornará 0.
            double numeroDoble  ;
            bool isNumero = double.TryParse(numero, out numeroDoble);
            if (isNumero)
            {
                return numeroDoble;
            }
            else return 0;
        }

        public static double operator +(Numero  numUno, Numero numDos)
        {         
           return numUno.numero + numDos.numero;
        }

        public static double operator -(Numero numUno, Numero numDos)
        {
            return numUno.numero - numDos.numero;
        }

        public static double operator *(Numero numUno, Numero numDos)
        {
            return numUno.numero * numDos.numero;
        }

        public static double operator /(Numero numUno, Numero numDos)
        {
            return numUno.numero / numDos.numero;
        }
        public static bool operator !=(Numero num2, int cero)
        {
            bool retorno = false;

            if (num2.numero != cero)
                retorno = true;
            return retorno;
        }
        public static bool operator ==(Numero num2, int cero)
        {
            return !(num2.numero != cero);
        }
        

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
