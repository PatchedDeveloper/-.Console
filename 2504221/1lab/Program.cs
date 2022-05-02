using System;
namespace _1lab
{
    class Program
    {
        static void Main()
        {
            string x;
            int sqr_x,forx,vx;
            Console.WriteLine("Введите x");
            x = Console.ReadLine();
            int i = Convert.ToInt32(x);
            sqr_x = (i * i); // 2 step
            forx = sqr_x * sqr_x; // 4 step
            vx = forx * forx; // 8 step
            Console.WriteLine(vx);




        }
    }
}
