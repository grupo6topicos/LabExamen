using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Seno
    {
        double a;
        double b;

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

        public double ValorSolucion { 
            get
            { return solucion; }
            set
            { solucion = ValorSolucion; }
        }

        public Seno() {
            ValorA = 0.0;
            ValorB = 0.0;
        }

        public Seno(double a, double b){
            ValorA = a;
            ValorB = b;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private void EncontrarSolucion() { 
            solucion = (- Math.Cos(b) + Math.Cos(a));
        }

        public void ObtenerSolucion(){
            if (VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            EncontrarSolucion();
        }
    }
}
