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


        public Potencia(double vA, double vB, int vExp){
            a = vA;
            b = vB;
            exp = vExp;
        }

        public bool VerificarRango() {
            bool resultado = true;
            if(b < a)
                resultado  = false;
            return resultado;

        }

        private double EncontrarSolucion()
        {
            return ((Math.Pow(b,(exp + 1))/(exp + 1))-((Math.Pow(a,(exp + 1))/(exp + 1))));
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
