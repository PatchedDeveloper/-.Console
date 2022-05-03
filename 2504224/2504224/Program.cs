using System;

namespace _2504224
{
    class Program
    {
        static void Main(string[] args)
        {
            string r,h;
            metka_1:
            Console.WriteLine("Введите радиус земли!");

            r = Console.ReadLine();
            int ri = Convert.ToInt32(r);

            Console.WriteLine("высоту глаз наблюдателя над поверхностью в метрах");

            h = Console.ReadLine();
            int hi = Convert.ToInt32(h);
            
            //reshenie zadachi

            int rihi = ri + hi;// r+h

            double kv = (double) Math.Pow(rihi,2);// r+h^2

            double vk = kv - (ri * ri);

            double s = (double) Math.Pow(vk, 2);// рост до гаризонта

            Console.WriteLine("Расстояние до гаризонта " + s + "км");

            int vh = (ri * 2);// расстояние от 1 острова до 2

            Console.WriteLine("расстояние от 1 острова до 2 " + vh + "км");

            double c = ((vh * vh) + (hi * hi));

            double vg = Math.Sqrt(c);
            
            if (vg > 0)
            {
             Console.WriteLine("Зона видимости от наивысшей точки острова до начала другого =" + vg + "км");
            }
            else
            {
                Console.WriteLine("ошибка в вычислениях");
                goto metka_1;
            }


        }
    }
}
