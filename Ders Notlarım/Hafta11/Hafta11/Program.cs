using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11
{
    internal class Program
    {
        //10 defa Merhaba yazdıran metod
        static void Merhaba()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba");
            }
        }
        //İki sayiyi toplayan metod
        static void ikiSayiTopla(int a,int b)
        {
            int top = a + b;
            Console.WriteLine(top);
        }
        //Diziyi yazdıran Metod
        static void diziYazdir(int[] dizi)
        {
            for(int i = 0;i < dizi.Length; i++)
            {
                Console.Write(dizi[i]+" ");
            }
            Console.WriteLine();
        }
        //Dizinin Elemanlarını toplayan Metod
        static void diziTopla(int[]dizi)
        {
            int top=0;
            for(int i = 0;i<dizi.Length ; i++) 
            {
                top += dizi[i];
            }
            Console.WriteLine(top);
        }
        //Dizinin Elemanlarını topla ve geri döndüren Metod
        static int diziElemanTopla(int[] dizi) 
        {
            int top = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                top += dizi[i];
            }
            return top;
        }
        //Metod parametre olarak aldığı 2 sayıdan büyük olanı dönsün
        static int buyukSayi(int a,int b) 
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        
        //Diziyi rastgele oluşturan Metod
        static void RastgeleDizi(int[] dizi)
        {
            Random r = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 10);
            }
            diziYazdir(dizi);
        }
        
        //static olmayan bir şeye erişmek için nesne yapmamız gerek mesela random sınıfı static olmadığı için nesne ile çağrılıyor ama math sınıfı otomatik olarak static olduğundan çağrılmasına gerek kalmıyor


        //yuvarlama metodlarını kendiniz yazınız
        static int asagiYuvarla(double a)
        {
            int sayi = (int)a;
            return sayi;
        }
        static int yukariYuvarla(double a)
        {
            int sayi = (int)a+1;
            return sayi;
        }
        static int yuvarla(double a)
        {
            int tam; double ondalik;
            tam = (int)a;
            ondalik = a-tam;
            if (ondalik<0.5)
            {
                return tam;
            }
            else
            {
                return tam+1;
            }
        }
        static void Carp(int a)
        {
            Console.WriteLine(a*10);
        }
        


        static void Main(string[] args)
        {
            //Merhaba();

            //ikiSayiTopla(8, 9);

            /*
            int [] aDizi= new int[10];
            Random rnd = new Random();
            for (int i = 0; i < aDizi.Length; i++)
            {
                aDizi[i] = rnd.Next(1,10);
            }
            diziYazdir(aDizi);

            diziTopla(aDizi);
            Console.WriteLine(diziElemanTopla(aDizi));
            */

            //Console.WriteLine(buyukSayi(8, 74)); 

            //int[]bDizi = new int[10];
            //RastgeleDizi(bDizi);

            //Console.WriteLine(Math.Ceiling(5.1));

            //Console.WriteLine(Math.Floor(5.9));

            //Console.WriteLine(asagiYuvarla(5.9));

            //Console.WriteLine(yukariYuvarla(5.1));

            //Console.WriteLine(yuvarla(8.6));

            //int sayi = 100;

            //double kalan = (3 + 5) / 8;

            //Carp(48);













































            Console.ReadLine();
        }
    }
}
