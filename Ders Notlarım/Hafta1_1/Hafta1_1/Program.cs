using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, e, c, top, carp;
            double ort;
            Console.WriteLine("A sayisini giriniz.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E sayisini giriniz.");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C sayisini giriniz");
            c = Convert.ToInt32(Console.ReadLine());
            top = a + e + c;
            carp = a * e * c;
            ort = ((double)a + (double)e + (double)c) / 3;
            Console.WriteLine("Toplam İşlemi:" + top);
            Console.WriteLine("Çarpma İşlemi:" + carp);
            Console.WriteLine("Ortalama işlemi:" + ort);
            Console.WriteLine("******************************************************");
            //bit operatörleri
            Console.WriteLine(2 & 3); //2
            Console.WriteLine(2 | 3); //3
            Console.WriteLine(2 >> 1); //1
            Console.WriteLine(2 << 1); //4
            Console.WriteLine(1 << 3); //8
            Console.WriteLine("A+B");
            Console.WriteLine("******************************************************");

            int x = 10, y = 50;
            if (x == 10 & y < 60)
            {
                Console.WriteLine("Doğru");
            }
            if (x == 10 & y < 20 & x < y)
                {
                    Console.WriteLine("Doğru");
                }
            else
                {
                    Console.WriteLine("Yanlış");
                }

                Console.ReadLine();
         }
    }
}

