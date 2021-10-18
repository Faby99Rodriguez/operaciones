using System;
using System.Collections.Generic;
using System.Text;

namespace operaciones
{
    class Division
    {
        public static double Divis(double a, double b)
        {
            return a / b;
        }


        public static String MostrarDiv(double a, double b)
        {
            double res = a / b;
            return "El resultado de " + a + "/" + b + "=" + res;
        }
    }
}
