using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int tur1,tur2,mat1,mat2,fen1,fen2;
            double ort1, ort2, ort3;
            Console.WriteLine("Türkçe Vize Notunu Giriniz:");
            tur1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Türkçe Final Notunu Giriniz:");
            tur2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matematik Vize Notunu Giriniz:");
            mat1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matematik Final Notunu Giriniz:");
            mat2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fen Vize Notunu Giriniz:");
            fen1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fen Final Notunu Giriniz:");
            fen2 = Convert.ToInt32(Console.ReadLine());
            ort1 = (tur1 * 0.4 + tur2 * 0.6);
            ort2 = (mat1 * 0.4 + mat2 * 0.6);
            ort3 = (fen1 * 0.4 + fen2 * 0.6);
            Console.WriteLine("Türkçe Ortalaması:"+ort1+"\nMatematik Ortalaması:"+ort2+"\nFen Ortalaması:"+ort3);
            if (ort1 > 50 & ort2 > 50 & ort3 > 50)
            {
                Console.WriteLine("Sınıfı Geçtiniz");
            }
            else {
                Console.WriteLine("Sınıfta Kaldınız");
            }
            Console.ReadLine();
            */
            
            int sayi;
            Console.WriteLine("Sayi giriniz:");
            sayi=Int32.Parse(Console.ReadLine());
            int kalan;
            kalan = sayi % 2;
            if (kalan == 0)
            {
                Console.WriteLine(sayi+" Çift");
            }
            else {
                Console.WriteLine(sayi + " Tek");
            }
            
            /*
            string deger = (kalan == 0) ? "Çift" : "Tek";
            Console.WriteLine(sayi+" "+deger);

            string ifade = (sayi> 0) ? "Pozitif" : "Negatif";
            Console.WriteLine(sayi + " " + ifade);

            int sayi1;
            Console.WriteLine("Sayi giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            if (sayi1 < 0)
            {
                Console.WriteLine(sayi1+"Negatif");
            }
            else if (sayi1 == 0){ 
                Console.WriteLine(sayi1+" Nötr");
            }
            else
            {
                Console.WriteLine(sayi1+" Pozitif");
            }
            */
            /*
            //Sayi tek ise 2 ile çarp çift ise 3 ile çarp
            Console.WriteLine((sayi %2==0)?sayi*3:sayi*2);
            int a = 5;
            int x;
            a += 1;
            x = a; 
            Console.WriteLine(x);
            int e = 3;
            int b;
            b = e;
            Console.WriteLine(b);
            */
            /*
            int sayi,sayi1;
            Console.WriteLine("Sayi giriniz:");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayi giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            if(sayi1 < sayi) {
                Console.WriteLine(sayi + " Sayisi en büyük");
            }
            else { Console.WriteLine(sayi1 + " Sayisi en büyük");
            }
            int sayi2, sayi3,sayi4;
            Console.WriteLine("Sayi giriniz:");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayi giriniz:");
            sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayi giriniz:");
            sayi4 = int.Parse(Console.ReadLine());
            if (sayi2 > sayi3 && sayi2 >sayi4)
            {
                Console.WriteLine(sayi2+" Sayisi en büyük");
            }
            else if (sayi3 > sayi2 && sayi3>sayi4)
            {
                Console.WriteLine(sayi3 + " Sayisi en büyük");
            }
            else
            {
                Console.WriteLine(sayi4 + " Sayisi en büyük");
            }
            */
            /*
            int gun = 4;
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default: Console.WriteLine("Yanlış değer girdiniz");
                    break;
                    */
            /*
            int gun = 2;
            switch (gun)
            {
                case 1:case 2:case 3:case 4:case 5:
                    Console.WriteLine("Hafta içi "+gun);
                    break;
                case 6: case 7:
                    Console.WriteLine("Hafta sonu"+gun);
                    break;
                default: Console.WriteLine("Yanlış değer");
                    break;
            }
            */
            //Alınan malzeme kategorisine ve fiyat değerine gööre belirlenen kdv oranlarını ile yeni fiyatı ekrana yazdırınız
            /*
            double fiyat;
            string malzeme;
            Console.WriteLine("Kategori Giriniz");
            malzeme=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Fiyat Giriniz");
            fiyat = Convert.ToDouble(Console.ReadLine());
            switch (malzeme)
            {
                case "A": case "B": case "C":
                    fiyat = fiyat + fiyat * (0.01);
                    break;
                case "D":case "E": case "F":
                    fiyat = fiyat + fiyat * (0.08);

                    break;
                case "G": case "H":
                    fiyat = fiyat + fiyat * (0.18);

                    break;
                default:
                    fiyat = fiyat + fiyat * (0.28);
                    break;
                    Console.WriteLine("Yeni Fiyat"+fiyat);
            }

            }
            */


            Console.ReadLine();
        }
    }
}
