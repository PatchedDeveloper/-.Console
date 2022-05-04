using System;

namespace _2604224
{
    class Program
    {
        static void Main()
        {
            const double p = 3.14;
          
            Console.WriteLine("Введите диаметр шара");
            double d = Convert.ToDouble(Console.ReadLine());
            double radius = d/2;
           
            double kub = (double)Math.Pow(radius, 3);
            double v = (1.33 * p * kub);

            Console.WriteLine("Обьем шара равен = " + kub);

            Console.WriteLine("Обьем шара равен = " + v);
        }
    }
}
