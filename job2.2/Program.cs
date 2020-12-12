using System;

namespace job2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Введите 1 значение");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 значение");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 3 значение");
                c = int.Parse(Console.ReadLine());
                int max = a;
                if (b > max) max = b;
                if (c > max) max = c;
                Console.WriteLine("max=" + max);
                if (a > b) a = b;
                if (a > c) a = c;
                Console.WriteLine("Min = {0}", a);
            }
            catch (Exception e)
            {
                Console.ReadKey();
            }
        }
            
    }
}
