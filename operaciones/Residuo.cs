using System;

namespace operaciones
{
    public class Residuo
    {
       
        public static double resid(double a, double b)
        {
            return a % b;
        }


        public static String Mostrar(double a,double b)
        {
            double res = a % b;
            return "El residuo  de " + a + "%" + b + "=" + res;
        }
    }
}
