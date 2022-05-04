using System;

namespace _2604222
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Какой информационный обьем у вашего сообщения В БИТАХ?");
            double n = Convert.ToDouble(Console.ReadLine());

            double b = n / 8;
            Console.WriteLine("В байтах это " + b);// БАЙТЫ

            double k = n / (8*1024);
            Console.WriteLine("В килобайтах это " + k);// КИЛОБАЙТЫ

            double m= n / (8*1024*1024);
            Console.WriteLine("В мегабайтах это " + m);// МЕГАБАЙТЫ


        }
    }
}
