using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Exponencial
    {
        double a;
        double b;

        public Exponencial(double vA, double vB){
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
            return Math.Pow(Math.E,b) - Math.Pow(Math.E,a);
        }

        public double ObtenerSolucion(){
            if (!VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
