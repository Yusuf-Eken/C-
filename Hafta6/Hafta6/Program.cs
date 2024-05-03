using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Diziler
            /*
            int[] A = new int[10];      //10 elemanlı tek boyut
            double[] X = new double[10]; //100 elemanlı tek boyut
            string[] S = new string[40]; //40 Elemanlı tek boyut
            char[,] harf = new char[3, 4];//3 satır 4 sütün 12 elemanlı iki boyutlu dizi
            int[,] b = new int[10, 10];   //10 satır 10 sütün 100 elemanlı iki boyutlu 
            */

            //Dizi tanımlaması
            /*
            int[] D = {1,2,3,4,5};
            string[] isimler = { "ali", "ahmet", "can", "mehmet", "veli" };

            int[,] K = { { 1, 2, 3 }, { 4, 5, 6 } };
            */

            //ORN1:
            /*
            int [] A = new int [100];
            string [] S = new string [40];
            int[,] sayi = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] R = new int[10, 10];

            A[0] = 12;
            A[9] = A[0] + 10;
            S[2] = "ali";
            R[3, 4] = 55;

            Console.WriteLine(A[0]);
            Console.WriteLine(A[9]);
            Console.WriteLine(S[2]);
            Console.WriteLine(R[3,4]);
            Console.WriteLine(sayi[1,2]);
            */

            //not:
            //int[,] R = new int [10,10];
            //int[][]R= new int [10][10];

            //Orn2 : Elemanları kullanıcıdan alınan 10 elemanlı bir dizinin 3. ve 7. elemanını toplayınız.
            /*
            int[] dizi = new int[10]; 
                for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine((i+1)+". Elemanını giriniz:");
                dizi[i] = int.Parse(Console.ReadLine());
            }
                //dizi yazdırma
                for (int i = 0;i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]+" ");
            }
            int top = dizi[2] + dizi[6]; //3. ve 7. eleman -- 2. ve 6. indexsine eşit
            Console.WriteLine(top);
            */

            //Orn3 x={50,47,15,50,75} verilen x dizisi içinde son rakamı 0 olan kaç tane sayı olduguunu bulunurz ve yazdırınız
            /*
            int[] x = { 50, 47, 15, 50, 75 };
            int sayac=0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]%10==0)
                {
                    sayac++;
                }
            }
            Console.WriteLine("son rakamı 0 olan "+ sayac+" tane sayı vardır");
            */
            //Orn4 10 elemanlı ve elemanları 10 50 arasında rastgele saıylardan oluşan bir diizinin elemanlarını yan yana yazdırınız
            /*
            Random nesne = new Random();
            int[] s = new int[10];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = nesne.Next(10,50);
                Console.WriteLine(s[i]+" ");
            }
            */
            //Orn5 öğrenci sayisini ve öğrenci isimlerini kullanıcan alarak n elemanlı bir öğrenci ad dizisi oluşturunuz ilk öğrencisinin adını yazdırsınız.
            /*
            int n;
            Console.WriteLine("Ogrenci sayisini giriniz:");
            n=Convert.ToInt32(Console.ReadLine());
            string[] OgrenciAd=new string[n];//n elemanlı dizi oluşturuldu.

            for (int i = 0; i < OgrenciAd.Length; i++)
            {
                Console.WriteLine(i+1+". ogrencinin adını giriniz:");
                OgrenciAd[i] = Console.ReadLine();
            }
            Console.WriteLine(OgrenciAd[0]);
            */
            //Orn6 10 elemanlı ve elemanları 10 20 arasında rastgele sayılardan oluşsan bir dizinin elemanlarını yan yana yazdırınız ve elemanlarını tersten yazdırınız.
            //a-bir dizinin elemanlarını yan yana yazdırınız.
            //b-elemanlarını toplayınız ve toplam sonucu yazdırınız
            //c-
            /*
            Random nesne = new Random();
            int top = 0;
            int[] s = new int[10];
            //bu for elemanlaır oluşturan döngü
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = nesne.Next(10, 20);
                top += s[i];
            }
            //bu döngü diziyi yazdıran
                var a = "ali";
                var b = 1232564;
                var c = 12.56;
                var d = true;
            foreach (int eleman in s)
            {
                Console.WriteLine(eleman+" ");
                top += eleman;

            }
            */

            //Orn7 5 elemanlı ve elemanları 0 10 arasında rastgele sayılardan oluşan bir dizinin elemanlarını yan yana yazdırınız  ve elemanlarını tersten yazdırınız.
            /*
            Random nsn = new Random();
            int[] dizi = new int[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = nsn.Next(0, 10);
                Console.Write(dizi[i]+" ");
            }
            Console.WriteLine("");
            for (int i = dizi.Length-1;i >= 0; i--)
            {
                Console.Write(dizi[i]+" ");
            }
            */
            //Orn8 10 elemanlı bir dizi tanımayınız elemanlarını 0 100 arasında rastgele atayarak 
            /*
            Random generator = new Random();
            int[] dizi = new int[10];
            int teksayac = 0, ciftsayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = generator.Next(0,100);
                Console.WriteLine(dizi[i]+" ");
                if (dizi[i] % 2 == 0)
                {
                    ciftsayac++;
                    
                }
                else{
                    teksayac++;
                }
            }
            Console.WriteLine("çift sayı adedi:"+ciftsayac);
            Console.WriteLine("çift sayi adedi:"+teksayac);
            */
            //15 elemanlı bir dizi tanımlayınız elemanları 10 40 arasında rastgele atayarak oluşturun
            /*
            Random generator = new Random();
            int top = 0;
            int[] dizi = new int[15];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = generator.Next(10, 40);
                Console.WriteLine(dizi[i] + " ");
                top += dizi[i];
            }
            Console.WriteLine("toplam:" + top);
            Console.WriteLine("ortalama"+(double)top/dizi.Length);
            */

            //30 elemanlı bir dizi tanımlayınız elemanlarını 1 10 arasında rastgele rakamlar oluşturun her bir rakamdan kaçar tane üretildiğiini bulunuz ve yazdırınız.
            //kaçar tane olduğu frekans demektir.
            /*
            Random generator = new Random();
            int[] dizi = new int[30];
            int[] rakam= new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = generator.Next(0, 10);
                Console.WriteLine(dizi[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < dizi.Length; i++)
            {
            for (int j = 0; j < rakam.Length; j++)
            {
                if (dizi[i] == j)
                {
                    rakam[j]++;
                }
            }
            foreach (int item in rakam)
            {
                Console.WriteLine(i);
            }
            */
            Random generator = new Random();
            int[] dizi = new int[100];
            int[] rakamFrekansı = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = generator.Next(0, 10); // 1-10 arası rakamlar
                Console.Write(dizi[i] + " ");

                // Her rakamın frekansını artır
                rakamFrekansı[dizi[i]]++;
            }

            Console.WriteLine("\nRakam Frekansları:");

            for (int i = 0; i < rakamFrekansı.Length; i++)
            {
                Console.WriteLine((i) + ": " + rakamFrekansı[i]);
            }
            






































            Console.ReadLine();
        }
    }
}
