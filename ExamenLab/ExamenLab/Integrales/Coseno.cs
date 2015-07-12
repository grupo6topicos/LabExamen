using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Coseno
    {
        double a;
        double b;

        public Coseno(double vA, double vB){
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
            return (Math.Sin(b) - Math.Sin(a));
        }

        public double ObtenerSolucion(){
            if (!VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
