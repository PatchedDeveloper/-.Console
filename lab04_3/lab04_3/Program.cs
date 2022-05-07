using System;

namespace lab04_3
{
    class Program
    {
        static int sum = 0;
        static int i = 0;
        static void Main()
        {
            int x;
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            NumberOfOdds(x);
        }
        static void NumberOfOdds(int x)
        {
            Console.WriteLine("NumberOfOdds loaded...");

            double one, two, three;

            one = x / 100;
            two = (x / 10) % 10;
            three = x % 10;

            if(i <= 1000000)
            {
                if (x > 0 || x < 0)
                {
                    if (one % 2 != 0)
                    {
                        sum++;
                    }
                    if (two % 2 != 0)
                    {
                        sum++;
                    }
                    if (three % 2 != 0)
                    {
                        sum++;
                    }
                    Main();
                }
                else
                {
                    Console.WriteLine("Вы ввели 0,идёт завершение программы...");
                    Console.WriteLine("Колличество нечётных цифр " + sum);
                   
                }
                i++;
             
            }
            else
            {
                Console.WriteLine("Вы превысили колличество возможных циклов!");

            }
          

        }
    }
}
