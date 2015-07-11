using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Constante
    {
        double a;
        double b;
        double k;

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

        public double ValorK
        {
            get
            { return k; }
            set
            { k = ValorK; }
        }

        public double ValorSolucion { 
            get
            { return solucion; }
            set
            { solucion = ValorSolucion; }
        }

        public Constante() {
            ValorA = 0.0;
            ValorB = 0.0;
            ValorK = 0.0;
        }

        public Constante(double a, double b, double k){
            ValorA = a;
            ValorB = b;
            ValorK = k;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private void EncontrarSolucion() { 
            solucion = (k*(b-a));
        }

        public void ObtenerSolucion(){
            if (VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            EncontrarSolucion();
        }
    }
}
