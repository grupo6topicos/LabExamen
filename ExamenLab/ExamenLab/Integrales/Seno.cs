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

        public Seno() {
            a = 0.0;
            b = 0.0;
        }

        public Seno(double vA, double vB){
            a = vA;
            b = vB;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private double EncontrarSolucion() { 
            return (- Math.Cos(b) + Math.Cos(a));
        }

        public double ObtenerSolucion(){
            if (!VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
