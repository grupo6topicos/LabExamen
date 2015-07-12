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

        public Constante(double vA, double vB, double vK){
            a = vA;
            b = vB;
            k = vK;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private double EncontrarSolucion() { 
            return (k*(b-a));
        }

        public double ObtenerSolucion(){
            if (!VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
