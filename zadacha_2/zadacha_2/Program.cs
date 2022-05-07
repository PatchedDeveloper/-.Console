using System;

namespace zadacha_2
{
    class Program
    {
        static void Main()
        {
            int first, two, three;
            Console.WriteLine("Введите 3 значное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            first = n / 100;
            two = (n / 10) % 10;
            three = n % 10;

            if (n%2==0) {
                double sum = first + two + three;
                Console.WriteLine("Ваше число четное его сумма =: "+ sum);

            }
            else
            {
                double proizv = first * two * three;
                Console.WriteLine("Ваше число не четное его произведение =: " + proizv);
            }
        }
    }
}
