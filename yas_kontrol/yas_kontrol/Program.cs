using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yas_kontrol
{
    class Kullanici
    {
        public string Isim { get; set; }
        private int yas;

        public Kullanici(string isim, int yas)
        {
            Isim = isim;
            this.yas = yas;
        }
        public void YasKontrol()
        {
            if (yas >= 18)
            {
                Console.WriteLine($"{Isim} Yetişkin");
            }
            else if (yas >= 13)
            {
                Console.WriteLine($"{Isim} Ergen");
            }
            else
            {
                Console.WriteLine($"{Isim} Çocuk");
            }
        }
        public int yasGoster()
        {
            return yas;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici kisi = new Kullanici("Ahmet", 20);
            kisi.YasKontrol();
            Console.WriteLine($"Ahmetin Yaşı: {kisi.yasGoster()}");

            Console.WriteLine();

            Kullanici kisi1 = new Kullanici("Ayşe", 15);
            kisi1.YasKontrol();
            Console.WriteLine($"Ayşenin Yaşı: {kisi1.yasGoster()}");


            Console.ReadLine();
        }
    }
}
