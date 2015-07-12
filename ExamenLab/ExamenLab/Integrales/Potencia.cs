using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Potencia
    {
        double a;
        double b;
        int exp;

        double solucion;

        public double ValorA
        {
            get
            { return a; }
            set
            { a = ValorA; }
        }

        public double ValorB
        {
            get
            { return b; }
            set
            { b = ValorB; }
        }

        public int ValorExp{
            get
            { return exp; }
            set
            { exp = ValorExp; }
        }

        public double ValorSolucion { 
            get
            { return solucion; }
            set
            { solucion = ValorSolucion; }
        }

        public Potencia() {
            ValorA = 0.0;
            ValorB = 0.0;
            ValorExp = 0;
        }

        public Potencia(double a, double b, int exp){
            ValorA = a;
            ValorB = b;
            ValorExp = exp;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private void EncontrarSolucion()
        {
            solucion = ((Math.Pow(b,(exp + 1))/(exp + 1))-((Math.Pow(a,(exp + 1))/(exp + 1))));
        }

        public void ObtenerSolucion()
        {
            if (VerificarRango())
            {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            EncontrarSolucion();
        }
    }
}
