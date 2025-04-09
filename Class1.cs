using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind3_karamov
{
    class Complex
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
            public double B
        {
            get { return b; }
            set { b = value; }
        }
        public static string Sum(double a1, double b1, double a2, double b2)
        {
            double sum1 = a1 + a2;
            double sum2 = b1 + b2;
            return $"{sum1} + {sum2}i";
        }
        public static string Razn(double a1, double b1, double a2, double b2)
        {
            double sum1 = a1 - a2;
            double sum2 = b1 - b2;
            return $"{sum1} + {sum2}i";
        }
        public static string Proizv(double a1, double b1, double a2, double b2)
        {
            double sum1 = a1*a2 - b1*b2;
            double sum2 = a1*b2 + b1*a2;
            return $"{sum1} + {sum2}i";
        }
    }
}
