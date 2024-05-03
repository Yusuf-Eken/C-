using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1vize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Soru
            //2 ondalık sayıyı kullanıcıdan al topla carp ve yazdır.
            /*
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çarpım:"+a*b);
            Console.WriteLine("Toplam:" +( a + b));
            */

            //2.Soru
            //1 den 100 e kadar tam sayıları arasında 4 ile tam bölünebilen sayıların kaç tane olduğunu bulan ve sonuçlarını ekrana yazdırın
            /*
            int sayac = 0;
            for (int i = 1; i <= 100; i++) {
                if (i % 4 == 0)
                {
                    sayac++;

                }
            }
            Console.WriteLine(sayac);
            */

            //3.Soru
            //kullanıcıdan alınan 2 sayının arasındaki çify sayıların toplamını bulnuz(Sasırtmalı Soru DDİKKAT?!!!!)
            /*
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int buyuk, kucuk,top=0;
            if (a > b) {
                buyuk = a;
                kucuk = b;
            }
            else
            {
                buyuk = b;
                kucuk = a;
            }
            for (int i = kucuk; i < buyuk; i++)
            {
                if (i%2==0)
                {
                    top += i;
                }
            }
            Console.WriteLine("Toplam:"+top);
            */

            //4.Soru
            //20 elemanlı bir sayı dizisi oluşturup rastgele 20 30 sayıları dahil dolduran ve dizi elemanlarını yazdırınız
            /*
            Random random = new Random();
            int [] dizi=new int[20];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i]=random.Next(20,31);
                Console.Write(dizi[i]+" ");
            }
            */

            //5.Soru
            //n ve m kullanıcıdan alınacaktır n x m uzunlukta iki boyutlu bir dizi oluşturunuz matrisin elemanlarını 3 sayısı olarak atayınız.
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[n, m];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = 3;
                    Console.Write(matris[i,j]+" ");
                }
                Console.WriteLine();
            }
            */































            Console.ReadLine();
        }
    }
}
