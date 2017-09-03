using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 2;
            double x1 = Math.PI/4;
            double e = 0.001;
            double x = method_hord(x0, x1, e);
            Console.WriteLine(x);
            Console.ReadLine();

        }

        public static double method_hord(double pred, double value, double e)
        {
            double next = 0;
            double tmp;

            do
            {
                tmp = next;
                next = value - f(value) * (pred - value) / (f(pred) - f(value));
                pred = value;
                value = tmp;
            } while (Math.Abs(next - value) > e);

            return next;
        }

        public static double f(double x)
        {
            return (2 * Math.Sin(2 * x) * Math.Sin(2 * x)) / 3 - (3 * Math.Cos(2 * x) * Math.Cos(2 * x)) / 4;
        }
    }
}
