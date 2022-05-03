using System;

namespace _2504223
{
    class Program
    {
        static void Main()
        {
            string x, m, n, p, a, b, c, d, e,l;
            double dvp = 2.5, pervskob, vtskob, nzpervskob, lognz;
            Console.WriteLine("Введите значения переменных ниже! ");

            // обьявление переменных
            Console.WriteLine("Переменная а : ");
            a = Console.ReadLine();
            int ai = Convert.ToInt32(a); //a

            Console.WriteLine("Переменная b : ");
            b = Console.ReadLine();
            int bi = Convert.ToInt32(b); //b

            Console.WriteLine("Переменная c : ");
            c = Console.ReadLine();
            int ci = Convert.ToInt32(c); //c

            Console.WriteLine("Переменная d : ");
            d = Console.ReadLine();
            int di = Convert.ToInt32(d); //d

            Console.WriteLine("Переменная e : ");
            e = Console.ReadLine();
            int ei = Convert.ToInt32(e); //e

            Console.WriteLine("Переменная m : ");
            m = Console.ReadLine();
            int mi = Convert.ToInt32(m); //m

            Console.WriteLine("Переменная n : ");
            n = Console.ReadLine();
            int ni = Convert.ToInt32(n); //n


            Console.WriteLine("Переменная p : ");
            p = Console.ReadLine();
            int pi = Convert.ToInt32(p); //p




            //логика приложения
            int avn = (int)Math.Pow(ai,ni);// a v step n

            double dskbodn = (double) Math.Pow(2, (1 /(double) ni));// 2 v step 1/n 

            double bvkv = (double)Math.Pow(bi, dvp); //b v stepeni 2.5

            //решение внутри скобок
            pervskob = 12.3 + 52.7 * avn / bvkv; // pervaya skobka

            vtskob = 12.3 - 52.7 * avn / bvkv; // vtoraya skobka

             // итог числителя
            double verh = dskbodn * pervskob * vtskob; // chislitel


            //решение знаменателя

            double evm = (double)Math.Pow(ei,mi); //e v m

            double vremper2 = Math.Sin(evm);

            double ytt =(double) Math.Sin(4);

            Console.WriteLine(ytt);// PROVERIT SIN

            double vremper= (132.5 + Math.Sin(evm));//skobka

   
            
            nzpervskob = Math.Sqrt(vremper);//sqrt skobka

            lognz = Math.Log(nzpervskob);// log per skobk


            double dvsp = (double)Math.Pow(di, pi);// d v stepeni p

            double dlcos = dvsp * ci;// dlya cos

            double cos = Math.Cos(dlcos);// cosin

            double zxc = lognz - cos;// nizhnya skobka

            double xr = verh / zxc;// all virazhenie

            Console.WriteLine(xr);






        }
    }
}
