using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,e;
            int top, fark,carp, mod;
            double bol;
            Console.WriteLine("A sayisini giriniz.");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E sayisini giriniz.");
            e=Convert.ToInt32(Console.ReadLine());
            top = a + e;
            fark = a - e;
            bol = a / e;
            carp = a * e;
            mod = a % e;
            Console.WriteLine("Toplam İşlemi:"+top);
            Console.WriteLine("Fark İşlemi:"+fark);
            Console.WriteLine("Bolme İşlemi:"+bol);
            Console.WriteLine("Carpma İslemi:"+carp);
            Console.WriteLine("Mod İşlemi:" + mod);
            Console.ReadLine();

        }
    }
}
