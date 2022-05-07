using System;

namespace mass01
{
    class Program
    {
        
        static void Main()
        {
            int x;
            Console.WriteLine("Введите число n :");
            x = Convert.ToInt32(Console.ReadLine());
            SumOfDigits(x);
        }
        static void SumOfDigits(int x){

            Console.WriteLine("SumOfDigits Запущен идет рассчет...");

            double one,two,three;

            one = x / 100;
            two = (x / 10) % 10;
            three = x % 10;

            double sum = one + two + three;

            Console.WriteLine("Сумма равна "+sum);
        }
    }
}
