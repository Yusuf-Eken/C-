using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //for(int i = 0; i <= 100; i++) {
                //    Console.WriteLine(i);
                //}

                //int a = 0;
                //while(a<=100) {
                //    Console.WriteLine(a);
                //    a++;
                //}

                //int b= 0;
                //do
                //{
                //    Console.WriteLine(b);
                //      b++;
                //} while (b<=100);

                /*1 den 10 a kadar olan sayıların toplamı

                int top = 0;
                for(int i = 0;i < 10;i++) {
                    Console.WriteLine(i);
                    top += i;
                }
                Console.WriteLine(top);
                */


                /*1 den kullanıcıdan alınan sayıya kadar olan sayıları toplayan alg.

                Console.WriteLine("Bir sayi giriniz:");
                int sayi,top=0,a=0;
                sayi=Convert.ToInt32(Console.ReadLine());
                while(a<=sayi) {
                    Console.WriteLine(sayi);

                    top += a;
                    a++;
                }
                Console.WriteLine(top);
                */
                /*

                Console.WriteLine("1 ile 100 arasındaki çift sayılar");
                for (int i=0;i<100;i++)
                {
                    if(i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("1 ile 100 arasındaki tek sayılar");
                for (int a = 0; a < 100; a++)
                {
                    if (a % 2 == 1)
                    {
                        Console.WriteLine(a);
                    }
                }
                */

                //10 ve 20 arasındaki tek sayıları toplayınız ve toplam sonucunu yazdırınız.

                //int top = 0;
                //for (int c = 10; c < 20; c++)
                //{
                //    if (c % 2 == 1)
                //    {
                //        top += c;
                //    }

                //}
                //Console.WriteLine(top);


                //100 den 1 e kadar 

                //for (int i = 100; i >= 1; i--)
                //{
                //    Console.Write(" " + i);
                //}

                //1 50 arasında 3 ün katı olan sayıları yazdırınız.

                //for(int i = 1; i < 50; i++) {
                //    if (i % 3 == 0)
                //    {
                //        Console.WriteLine(i);
                //    }
                //}

                //1 50 arasında 5 ün katı olan sayıları yazdırınız.

                //for (int i = 1; i < 50; i++)
                //{
                //    if (i % 5 == 0)
                //    {
                //        Console.WriteLine(i);
                //    }
                //}

                //Kullanıcıdan alınan sayının pozitif tam bölenlerini yazdırınız

                //int sayi;
                //Console.WriteLine("Sayı giriniz");
                //sayi = Convert.ToInt32(Console.ReadLine());
                //for (int i = 1; i <= sayi; i++)
                //{

                //    if (sayi % i == 0)
                //    {

                //        Console.WriteLine(i);
                //    }

                // 1 le 100 arasında çift sayıların kaç tane olduğunu görün

                //int sayac=0;
                //for(int i = 1; i <= 100; i++) {
                //    if (i % 2 == 0)
                //    {
                //        Console.Write(i+" ");
                //        sayac++;
                //    }
                //}
                //Console.WriteLine("\n");
                //Console.WriteLine("\n1 ile 100 arasında olan çift sayıların adeti:"+sayac);

                // 1 le 100 arasında 3 e bölünen sayıların kaç tane olduğunu görün

                //int sayac = 0;
                //for (int i = 1; i <= 100; i++)
                //{
                //    if (i % 3 == 0)
                //    {
                //        Console.Write(i + " ");
                //        sayac++;
                //    }
                //}
                //Console.WriteLine("\n");
                //Console.WriteLine("\n1 ile 100 arasında olan çift sayıların adeti:" + sayac);

                //10 satır olarak 1 den 5 e kadar sayıları yazmak için 

                //for (int i = 1; i <= 10; i++) {
                //    for (int j = 1; j <= 5; j++) {
                //        Console.Write(j+" ");
                //    }
                //    Console.WriteLine();
                //}

                //5x5 yıldız 

                //for (int i = 1; i <=5; i++) 
                //{
                //    for(int j = 1; j <=5; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                //1 ler çarpım tablosu

                //for(int i=1;i<=10;i++) 
                //{
                //    Console.WriteLine(1+"*"+i+"="+(i*1));
                //}

                //Çarpım tablosu

                //for (int i = 1; i <= 10; i++) 
                //{
                //    for (int j = 1; j <= 10; j++)
                //    {
                //        Console.WriteLine(i+"*"+j+"="+i*j);
                //    }
                //    Console.WriteLine();
                //}

                //Dışarıdan girilen sayının birler onlar yüzler basamaığını bulunuz ve basamak değerlerini toplayınız.
                /*
                int sayi, onlarBas, yuzlerBas, on, yuz, top;
                float birlerBas;
                Console.WriteLine("Sayi giriniz:");

                sayi = Convert.ToInt32(Console.ReadLine());

                birlerBas = sayi % 10;
                onlarBas = sayi % 100;
                yuzlerBas = sayi % 1000;
                on = onlarBas / 10;
                yuz = yuzlerBas / 100;
                top = on + yuz + (int)birlerBas;

                Console.WriteLine("Sayinin birler basamağı:" + birlerBas);
                Console.WriteLine("Sayinin onlar basamağı:" + on);
                Console.WriteLine("Sayinin yüzler basamağı:" + yuz);
                Console.WriteLine("Basamakların toplamı:" + top);
                */
                //kolay yolu
                /*
                int basamak;
                int t = 0;
                int sayi = 0;
                do
                {
                basamak = sayi % 10;
                t += basamak;
                Console.WriteLine(basamak);
                sayi = sayi / 10;
                } while (sayi > 0);
                Console.ReadLine;
                */
            }
                
        }
                
    }


