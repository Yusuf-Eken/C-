using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hafta5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Kullanıcıdan alınan 3 basamaklı sayının yüzler basamağını bulunuz eğer 3 basamaaklı değilse uyarı mesajı veriniz.

            /*
            int sayi=0;
            Console.WriteLine("3 Basamakli bir sayi giriniz:");
            sayi = int.Parse(Console.ReadLine());
            if (sayi >= 100 && sayi <= 999)
            { 
                Console.WriteLine("Sayinin Yüzler Basamağı:" + sayi / 100);
            }
            else
            {
                Console.WriteLine("Bu sayi 3 basamaklı değil!");
            }
            */

            //Kullanıcıdan alınan 3 basamaklı sayının onlar basamağını bulunuz eğer 3 basamaklı değil ise Uyarı mesajı veriniz.

            /*
            Console.WriteLine("3 Basamakli bir sayi giriniz:");
            int sayi = 0;
            sayi = int.Parse(Console.ReadLine());
            if (sayi >= 100 && sayi <= 999)
            {
                Console.WriteLine("Sayinin Onlar Basamağı:" + (sayi % 100) / 10);
            }
            else
            {
                Console.WriteLine("Bu sayi 3 basamaklı değil!");
            }
            */

            //Kullanıcıdan alınan 3 basamaklı sayının birler basamağını bulunuz eğer 3 basamaklı değil ise uyarmı mesajı veriniz.

            /*
            Console.WriteLine("3 Basamakli bir sayi giriniz:");
            int sayi = 0;
            sayi = int.Parse(Console.ReadLine());
            if (sayi >= 100 && sayi <= 999)
            {
                Console.WriteLine("Sayinin Birler Basamağı:" + (sayi % 10));
            }
            else
            {
                Console.WriteLine("Bu sayi 3 basamaklı değil!");
            }
            */

            //Kullanıcıdan alınan sayının sayıyı 2 lik sisteme dönüştürün.

            /*
            int sayi;
            Console.WriteLine("Sayi giriniz");
            sayi = int.Parse(Console.ReadLine());
            int kalan;
            var sonuc="";

            do
            {
                kalan = (sayi % 2);
                //Önüne ekle dememiz gerekiyor.
                sonuc = kalan.ToString()+sonuc;
                sayi = sayi / 2;

            }while (sayi > 0);

            Console.WriteLine(sonuc);
            */

            //Kullanıcıdan alınan sayının değerine göre 1-2+3-4+5....n in sonucunu hesaplayınız
            //Güzel Soru//

            /*
            int sayi;
            Console.WriteLine("Sayi Giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
                int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 1)
                {
                    toplam += i;
                }
                else
                {
                    toplam -= i;
                }
            }
            Console.WriteLine(toplam);
            */

            /*
             int sayi;
            Console.WriteLine("Sayi Giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
            int top=0;
            int isaret=-1;
            
            for(int i=1; i<=n;i++){

                isaret*=;
                top+=;
            }
            Console.WriteLine("Toplam:"+top);
            */

            //Kullanıcıdan alınan 10 sayıyı toplayarak 5. girilen sayıyı bölünüz ve sonucu yazdırınız.
            //Güzel Soru//

            /*
            int sayi;
            int besSayi=1;
            int top=0;
            for(int i = 1;i <= 10; i++) {
                Console.WriteLine(i+". Sayiyı giriniz:");
                sayi = int.Parse(Console.ReadLine());

                if (i == 5)
                {
                    besSayi = sayi;
                }
                top += sayi;
            }
            Console.WriteLine(besSayi);
            Console.WriteLine(top);
            Console.WriteLine("5.Sayiya bölersek:" + top / besSayi);
            */

            //Kullanıcıdan alınan 5 sayıdan en büyüğü ve en küçüğü bulunuz

            /*
            int sayi,eKucuk=int.MaxValue,eBuyuk=int.MinValue;
            for(int i = 1; i <= 5; i++) {
                Console.WriteLine(i+". sayiyi giriniz:");
                sayi =Convert.ToInt32(Console.ReadLine());
                if (sayi > eBuyuk)
                {
                    eBuyuk = sayi;
                }

                if (eKucuk > sayi)
                {
                    eKucuk = sayi;
                }

            }
            Console.WriteLine("En büyük sayi:"+eBuyuk);
            Console.WriteLine("En küçük sayi:"+eKucuk);
            */
            /*
            int sayi;
            Console.WriteLine(1+".sayi:");
            sayi=Convert.ToInt32(Console.ReadLine());
            int max = sayi;

            for(int i = 2; i <= 10; i++) {
                Console.WriteLine(i+". sayi:");
                sayi=Convert.ToInt32(Console.ReadLine());
                if (sayi > max)
                {
                    max = sayi;
                }

            }
            Console.WriteLine("En büyük sayi:"+max);
            */


            //Fibonacci 1 1 2 3 5 8 13 21 şeklinde devam eden serinin ilk 10 elemanını yazdırınız.

            /*
            int a = 1, b = 1, c;
            Console.WriteLine(a+" \n"+b+" ");
            for (int i = 0; i < 10; i++) {

                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c+" ");

            }
            */

            //Kullanıcıdan alınan sayı asal mı kontrol edelim

            int sayi;
            Console.WriteLine("Sayi Giriniz:");
            sayi = int.Parse(Console.ReadLine());
            bool bayrak = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    bayrak = false;
                    break;
                }
            }
                if (bayrak == false)
                {
                    Console.WriteLine("Asal Değil");
                }
                else
                {
                    Console.WriteLine("Asal");
                }
            Console.ReadLine();
        }


            

        }
    }























