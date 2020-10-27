using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { /* iki sayıdan büyük
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
            */
            /*çarpım tablosu
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /* vize final ortalama
            int vize, final, ort;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50 || final < 50)
                Console.WriteLine("Kaldınız.");
            else
                Console.WriteLine("Geçtiniz.");

            Console.ReadKey(); */

            /*kelime uzunluğu
            string isim;
            Console.WriteLine("kelimenizi giriniz");
            isim = Console.ReadLine();

            Console.WriteLine("Karakter sayısı : {0}", isim.Length);

            Console.ReadLine(); */

            /* çarpma işlemini toplama ile yapma

            int sayi1, sayi2, sonuc = 0;
            Console.Write("1. sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc = sayi1 + sonuc;
            }
            Console.WriteLine("Çarpım Sonucu : " + sonuc);
            Console.ReadKey(); */
            hh
        }
    }
}
