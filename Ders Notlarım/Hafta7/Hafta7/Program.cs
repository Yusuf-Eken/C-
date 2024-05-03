using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GEÇEN SENENİN VİZE SORULARI

            //1

            /*
            int n;
            double coz=0;
            Console.WriteLine("N ssayisini giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                    coz+=(double)i / (i + 1.0);
            }
            Console.WriteLine(coz);
            */

            //2

            /*
            int n;
            double coz = 0;
            int pay = 1;
            Console.WriteLine("N sayisini giriniz:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                coz += pay / (double)i;
            }
            Console.WriteLine(coz);
            */

            //3- 9 elemanlı bir sayı dizisi tanımlayınız.dizinin elemanlarını kullanıcan
            //alarak diziyi oluşturunuz.yan yana yazdırınız ilk
            //ve sonuncu elemanlarını toplayınız.

            /*
            int[] dizi = new int [9];
            int top;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i+1+". elemanı giriniz:");
                dizi[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]+" ");
            }
            top = dizi[0] + dizi[8] + dizi[4];
            Console.WriteLine("ilk son ve orta elemanlarının toplamı:"+top);
            */

            //4- 10 elemanlı bir dizi tanımalyınız elemanları 1-9 dahil rastgele oluşturunuz diziyi yazdırınız elemanlarını %10 arttırınız yeni diziyi yazdırınız.

            /*
            Random rnd = new Random(9);
            double[] dizi = new double[10];
            double[]dizi1= new double[10];
            for (int i = 0; i < dizi.Length; i++) {
                dizi[i] = rnd.Next(1, 9);
                Console.Write(dizi[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = dizi[i] + (dizi[i] * 10) / 100;
                Console.Write(dizi1[i] + " ");
            }
            */

            //5- N x M uzunluklu matris oluşturunuz n m kullanıcıdan alınıcaktır.
            //elemanların herbiri 3 olsun.

            /*
            int n, m;
            Console.WriteLine("Satır sayısını giriniz:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütun sayısını giriniz:");
            m = int.Parse(Console.ReadLine());
            int[,]matris=new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matris[i,j] = 3;
                    Console.Write(matris[i,j]+" ");
                }
                Console.WriteLine();
            }
            */

            //6- 2x3 uzunluklu matris oluşturunuz elemanları 4 olsun matrisyel görünüme sahip olsun

            /*
            int top = 0;
            int[,] matris = new int[2, 3];
            Console.WriteLine(matris.Length); //C# :2x3=6
            Console.WriteLine(matris.GetLength(0)); //satır sayısı
            Console.WriteLine(matris.GetLength(1)); //sutun sayisi

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = 4;
                    Console.Write(matris[i, j] + " ");
                    top += matris[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(top);
            */

            //7- 3x3 rastgele sayılardan oluşan matris dizisi oluşturunuz.random sayılar ile
            //oluşsun 1. diziyi 5 ile genişleterek   2. diziyi oluşturunuz

            /*
            int top = 0,n;
            int[,] matris= new int[3,3];
            int[,] matris1 = new int[3, 3];
            n = Convert.ToInt32(Console.ReadLine());
            Random nsn= new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = nsn.Next(1,10);
                    Console.Write(matris[i, j] + " ");
                    matris1[i, j] = matris[i, j] * n;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(1); j++)
                {
                    Console.Write(matris1[i,j]+" ");
                }
                Console.WriteLine();
            }
            */

            //MATRİS GELİR DİZİ GELİR VİZE DE DAHA AĞIRLIKLIDIR.

            //3- 9 elemanlı bir sayı dizisi tanımlayınız.dizinin elemanlarını kullanıcan alarak diziyi oluşturunuz.yan yana yazdırınız ilk ortanca
            //ve sonuncu elemanlarını toplayınız.
            
            int top;
            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Dizinin "+(i+1)+". Elemanını giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < dizi.Length; i++) 
            {
                Console.Write(dizi[i]+" ");
            }
            top = dizi[0] + dizi.Length-1 + dizi[dizi.Length / 2];
            Console.WriteLine(" ");
            Console.WriteLine(top);
            

            Console.ReadLine();
        }
    }
}
