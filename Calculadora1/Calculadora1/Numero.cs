using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Numero
    {
        private double numero;


        public double getNumero()
        {
            return this.numero;
        }


        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }


        public Numero(string numero)//Validar si es solo  que sea numero
        {

            setNumero(numero);



        }

        private double validarNumero(string numeroString)
        {
            //validar que solo  se trate de un  numero  de tipo  double
            bool esNumero = false;
            double aux;
            esNumero = double.TryParse(numeroString, out aux);
            if (esNumero == true)
            {
                return aux;
            }
            return 0;
        }

        private void setNumero(string numero)
        {
            double retorno = validarNumero(numero);
            if (retorno != 0)
            {
                this.numero = Convert.ToDouble(numero);
            }
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.getNumero() + numero2.getNumero();

        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.getNumero() - numero2.getNumero();

        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.getNumero() * numero2.getNumero();

        }

        public static double operator /(Numero numero1, Numero numero2)
        {

            return numero1.getNumero() / numero2.getNumero(); ;

        }


        public static bool operator !=(Numero numero1, double numero)
        {
            if (numero1 != numero)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Numero numero1, double numero)
        {
            if (numero1 == numero)
            {
                return true;
            }
            return false;
        }
    }
}
