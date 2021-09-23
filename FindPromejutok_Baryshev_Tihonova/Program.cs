using System;

namespace FindPromejutok_Baryshev_Tihonova
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            double x1 = a;
            double x2 = a + h;
            double y1 = Function(x1);
            double y2;

            while(x2 < b)
            {
                y2 = Function(x2);

                if((y1 * y2) < 0)
                {
                    Console.WriteLine("x1 :" + x1 + " x2: " + x2);
                }
                x1 = x2;
                x2 = x1 + h;
                y1 = y2;
            }

        }

        public static double Function(double x)
        {

            return x * Math.Sin(x) - 1;
        }
    }
}
