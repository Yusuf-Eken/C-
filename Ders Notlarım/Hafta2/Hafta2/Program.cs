using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı Girin");
            long sayi1=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayının hangi kat sayılarını istediğinizi yazın");
            long sayi2=int.Parse(Console.ReadLine());
            for(long i = 1; i < sayi1; i++) { 
            if(i%sayi2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            double bolum;
            bolum = (double)sayi1 / sayi2;
            Console.WriteLine(sayi1+" sayısının "+sayi2+" sayısına bolumu= " + (double)sayi1 / sayi2);
            Console.ReadLine();


        }
    }
}
