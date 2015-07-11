﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ExamenLab.Integrales;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IResolverIntegrales
    {

        public double Integral(double a, double b, double k, int exp, string type) {
            double resultado = 0.0;
            switch (type) { 
                case "Simple":
                    

                    break;
                case "Constante":
                    Constante integral = new Constante(a, b, k);
                    integral.ObtenerSolucion();
                    resultado = integral.ValorSolucion;
                    break;
            }
            return resultado;
        }
    }
}
