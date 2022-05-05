using System;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,f;
            int a, b, c;
            Console.WriteLine("Введите значения x (a,b,c- дейтвительные числа)");

            Console.WriteLine("Введите значения x ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения a ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значения b ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значения c ");
            c = Convert.ToInt32(Console.ReadLine());

            if((a<0) && (c!=0))
            {
                f = a * Math.Pow(x, 2) + b * x + c;
                Console.WriteLine("f= " + f);
            }
            else if ((a > 0) && (b == 0))
            {
                f = -(a) / (x - c); 
                Console.WriteLine("f= " + f);
            }
            else
            {
               f= a * (x + c);
                Console.WriteLine("f= " + f);
            }

        }
    }
}
