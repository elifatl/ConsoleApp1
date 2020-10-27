using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("1.Sayıyı Gir:");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayıyı Gir:");
            y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
            Console.Read();
        }
    }
}
