using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Simple
    {
        double a;
        double b;

        public Simple(double vA, double vB)
        {
            a = vA;
            b = vB;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b  < a)
                resultado  = false;
            return resultado;

        }

        private double EncontrarSolucion() {  
            return (b-a);
        }

        public double ObtenerSolucion()
        {
            if (!VerificarRango()) {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
