using System;

namespace _2604221
{
    class Program
    {
        static void Main()
        {
            const double p = 3.14;
            double r,s;
            Console.WriteLine("введите Диаметр окружности->");
            double d = Convert.ToDouble(Console.ReadLine());
            r = d / 2;
            s = p * (Math.Pow(r, 2));
            Console.WriteLine("Площадь окружности S = "+ s);
        }
    }
}
