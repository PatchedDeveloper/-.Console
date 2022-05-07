using System;

namespace lab4_2
{
    class Program
    {
        static int w=0;
        static void Main()
        {

 
            int x;
            Console.WriteLine("");
            Console.WriteLine("Введите число :");
            x = Convert.ToInt32(Console.ReadLine());

            if ( x< 0 || x>0) {
                w += x;
                SumOfDigits(x);
            }
            else
            {
                Console.WriteLine("Вы ввели 0, Программа завершена" );
                Console.WriteLine("Сумма всех чисел равна = "+w);
            }

        }
        static void SumOfDigits(int x)
        {
            Console.WriteLine("SumOfDigits Запущен идет рассчет...");
            Console.WriteLine("Ваше число " + x);
            Main();

        }
    }
}
