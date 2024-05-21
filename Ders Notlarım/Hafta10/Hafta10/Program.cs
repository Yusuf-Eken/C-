using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String fonksiyonlar
            //Nesne oluşturma
            //ilk yaptığımız nesnelerden biri: Random nesne=new Random();
            //Class belirtip nesnemizin ismini yazıyoruz

            /*
            string okul = "Gölyaka";
            char c = 'a';
            Console.WriteLine(okul);
            Console.WriteLine(c);
            */

            //Stringdeki karakterlere ulaşmak için 

            /*
            Console.WriteLine(okul[3]);
            Console.WriteLine(okul[2]);
            */

            //Düzce kelimesindeki harfleri alt alta yazdırınız.

            /*
            string okul1 = "Düzce";
            for (int i = 0; i < okul1.Length; i++)
            {
                Console.WriteLine(okul1[i]);
            }
            */

            //Düzce kelimesindeki harfleri yan yana yazdırınız.

            /*
            for (int i = 0; i < okul1.Length; i++)
            {
                Console.Write(okul1[i]+" ");
            }
            */

            //bir karakter dizisi tanımlayalım

            /*
            char[] isim = { 'M', 'U', 'H','A','M','M','E','D' };
            string isimYeni = "";
            for (int i = 0; i < isim.Length; i++) 
            {
            isimYeni += isim[i];
            }
            Console.WriteLine(isimYeni);
            

            //YA DA

            Random rnd = new Random();
            string nesne = new string(isim);
            Console.WriteLine(nesne);
            */

            /*
            String str = "Bolu";
            Console.WriteLine(str.Length);

            //Stringi büyük-küçük harf yapmak
            
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            //String ifadeden parça almak için
            Console.WriteLine(str.Substring(2));

            //Sınavda soruldu
            String seh1 = "Karşıyaka";
            String seh2 = "Gölcük";
            Console.WriteLine((seh2.Substring(0,3)+seh1.Substring(5)));
            */

            /*
            string degisken = "xoxoxo";
            //x harflerini  w ile doldurunuz
            Console.WriteLine(degisken.Replace('x','w'));
            //xo kelimesini sa ile değiştiriniz
            Console.WriteLine(degisken.Replace("xo","sa"));
            //Karşıyadaki yaka kısmını silsin
            String seh1 = "Karşıyaka";
            Console.WriteLine(seh1.Remove(5));

            //Dışarıdan girilen bir stringi ters çevirin

            string kul=Console.ReadLine();
            for (int i =kul.Length-1; i >= 0; i--)
            {
                
                Console.WriteLine(kul[i]);
            }
            //length metodu kullanmadan aynı soruyu yaz
            foreach(var item in kul)
            {
                Console.WriteLine(item);
            }
            */
            //Kullanıcıdan alınan cümledeki kelime sayısını bulunuz.
            /*
            string cumle = Console.ReadLine();
            int sayac=1;
            char bosluk = ' ';
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i].Equals(' '))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Cumledeki Kelime sayisi:"+sayac);
            //Stringler karşılaştırırken bu metodlar kullanılır:
            //a.CompareTo(b) /-1 /0
            //a.Equals(b) /True /False
            //METİNSEL KARŞILAŞTIRMA İŞLEMLERİNİ EŞİTTİR YERİNE BU KOMUTLARI İLE YAPMANIZ DOĞRUDUR
            */


            //SINAV SORUSU

            //İsminizi Kullanıcı olarak giriniz isminizdeki karakter sayısınca isminizi ekrana alt alta yazdırınız
            /*
            String isim = Console.ReadLine();
            int uzunluk = isim.Length;
            for (int i = 1; i <= (isim.Length*2); i++) 
            {
                Console.WriteLine(isim);
            }
            //isimin son harfini getir
            Console.WriteLine(isim[isim.Length-1]);
            Console.WriteLine(isim[0]);
            */

            //Kullanıcıdan alınan kelimenin polindrom olup olmadığını yazınız
            //polindrom kelime ve kelimenin tersi aynı olursa
            /*
            string kelime = Console.ReadLine();
            string terskelime = "";
            for (int i = kelime.Length - 1; i >= 0; i--) {
                terskelime += kelime[i];
                }
                if (kelime == terskelime)
                {
                    Console.WriteLine("Polindrom");
                }
                else
                {
                    Console.WriteLine("Değil");
                }
            */

            //ToUpper() = Büyük harf yapar.
            //ToLower() = Küçük harf yapar.
            //Substring(baslangic indexi,o indexten sonra kaç tanesini alacak) = Kelimeden parça alma.
            //Replace(aranan deger,değiştiriceğin değer) = Değiştirme değeri bul değiştir mantığı ile çalışır.
            //Remove(baslangic indexi,o indexten sonra kaç tanesini silecek) = Sil

            //Stringler karşılaştırırken bu metodlar kullanılır:
            //(1.Sınıf).CompareTo((Karşılaştırılan Sınıf)) -1 ya da 0 çıktısı verir
            //(1.Sınıf).Equals((Karşılaştırılan Sınıf)) True ya da False çıktısı verir
            //METİNSEL KARŞILAŞTIRMA İŞLEMLERİNİ EŞİTTİR YERİNE BU KOMUTLARI İLE YAPMANIZ DOĞRUDUR
            //ÇÜNKÜ METİNSEL İŞLEMLERDE EŞİTTİR KULLANILAMAZ.


            //İsminizi Kullanıcı olarak giriniz isminizdeki karakter sayısınca isminizi ekrana alt alta yazdırınız
            /*
            Console.Write("İsim Giriniz:");
            String isim=Console.ReadLine();
            String isim1 = " ";
            isim1 += isim;
            for (int i = 0; i < isim.Length; i++) 
            {
                
                Console.WriteLine(isim1);
            }
            */ 
            //İsminizi Kullanıcı olarak giriniz isminizdeki karakter sayısınca isminizi ekrana alt alta yazdırınız
            String isim=Console.ReadLine();
            String isim1 = " ";
            isim1 += isim;
            for (int i = 1; i <isim1.Length; i++)
            {
                Console.WriteLine(isim);
            }
            
            Console.ReadLine();

        }
    }
}
