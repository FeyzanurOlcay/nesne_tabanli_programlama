using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Convert" ile tür dönüşümü
            // string -- int 
            string metin = "123";
            int sayi = Convert.ToInt32(metin);
            Console.WriteLine(sayi);

            // char-- int
            char karakter = 'ş';
            int krktr = Convert.ToInt32(karakter);
            Console.WriteLine(krktr);

            // bool -- string
            bool deger = true;
            string dgr = Convert.ToString(deger);
            Console.WriteLine(dgr);


            // "ToString" ile tür dönüşümü
            // int -- string
            int a = 23;
            string b = a.ToString();
            Console.WriteLine(b);

            // double--string
            double sayi2 = 123.43;
            string mtn = sayi2.ToString();
            Console.WriteLine(mtn);

            // bool-- string
            bool drm = true;
            string durum = drm.ToString();
            Console.WriteLine(durum);


            // "parse" ile tür dönüşğmü
            // string-- double
            string c = "124.34";
            double sayi1 = double.Parse(c);
            Console.WriteLine(sayi1);

            // string-- DateTime
            string tarih = "2024-04-12";
            DateTime trh = DateTime.Parse(tarih);
            Console.WriteLine(trh);

            // string--bool
            string deger_ = "true";
            bool dgr_ = bool.Parse(deger_);
            Console.WriteLine(dgr_);


            // bilinçsiz tür dönüşümü 
            short s = 3200;
            int x = s; // short-- int
            double y = s; // short--double


            // bilinçli tür dönüşğmü
            // double-- int
            double sayii = 32.145;
            int _sayi = (int)sayii;
            Console.WriteLine(_sayi);



            Console.ReadLine();

        }
    }
}
