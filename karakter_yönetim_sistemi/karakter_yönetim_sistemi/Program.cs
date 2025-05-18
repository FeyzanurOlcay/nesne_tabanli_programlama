using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakter_yönetim_sistemi
{
    class Karakterr
    {
        private string isim;
        private string yetenek;
        private int guc;
        private int can;

        public Karakterr(string isim, string yetenek, int can, int guc)
        {
            this.isim = isim;
            this.yetenek = yetenek;
            this.guc = guc;
            this.can = can;
        }
        public void hasarAl(int miktar)
        {
            can -= miktar;

            if(can<=0)
            {
                can = 0;
                Console.WriteLine($"{isim} öldü! Ruhuna El-Fatiha.");
            }
            else
            {
                Console.WriteLine($"{isim} {miktar} hasar aldı.Kalan canınız:{can}");
            }
        }
        public void guc_artir(int miktar)
        {
            guc += miktar;
            Console.WriteLine($"{isim} gücü {miktar} arttı. Güncel güç durumunuz:{guc}");
        }
        public void bilgi()
        {
            Console.WriteLine("Karakter Bilgileri:");
            Console.WriteLine($"İsim:{isim} ");
            Console.WriteLine($"Güç:{guc}");
            Console.WriteLine($"Can:{can}");
            Console.WriteLine($"Yetenek:{yetenek}");
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<***>>>>>>>>>>>");
            Console.WriteLine();

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Karakterr okcu = new Karakterr("Okçu", "Keskin Nişan", 100, 60);
            Karakterr buyucu = new Karakterr("Büyücü", "Alev Topu", 80, 60);
            Karakterr savasci = new Karakterr("Savaşçı", "Kılıç Kullanma", 100, 70);

            okcu.bilgi();
            buyucu.bilgi();
            savasci.bilgi();

            okcu.hasarAl(30);
            buyucu.hasarAl(20);
            savasci.hasarAl(40);
            Console.WriteLine();

            okcu.guc_artir(25);
            savasci.guc_artir(30);
            Console.ReadLine();


        }
    }
}
