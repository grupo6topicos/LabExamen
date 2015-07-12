using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLab.Integrales
{
    public class Logaritmo
    {
        double a;
        double b;

        public Logaritmo(double vA, double vB){
            a = vA;
            b = vB;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private double EncontrarSolucion()
        {
            return Math.Log(Math.Abs(b)) - Math.Log(Math.Abs(a));
        }

        public double ObtenerSolucion()
        {
            if (!VerificarRango())
            {
                throw new Exception("El valor [b] debe ser mayor al valor [a]");
            }

            return EncontrarSolucion();
        }
    }
}
