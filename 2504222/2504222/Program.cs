using System;

namespace _2504222
{
    class Program
    {
        static void Main()
        {
            string x;
            int first,two,three,sum;
            Console.WriteLine("Введите 3 значное число: ");
            x = Console.ReadLine();
            int i = Convert.ToInt32(x);

            first = i / 100;
            two = (i / 10) % 10;
            three = i % 10;

            sum = first + two + three;

            Console.WriteLine("Сумма всех чисел равна:" + sum);

        }
    }
}
