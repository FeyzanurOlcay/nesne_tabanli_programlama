using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirket_personel
{
    class personel
    {
        public int id;
        public string isim;
        public string pozisyon;
        public string departman;
        public int maas;

        public personel(int id, string isim, string pozisyon, string departman, int maas)
        {
            this.id = id;
            this.isim = isim;
            this.pozisyon = pozisyon;
            this.departman = departman;
            this.maas = maas;

        }

        public void bilgiGoster()
        {
            Console.WriteLine("PERSONEL BİLGİLERİ");
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"ISIM : {isim}");
            Console.WriteLine($"POZİSYON : {pozisyon}");
            Console.WriteLine($"DEPARTMAN : {departman}");
            Console.WriteLine($"MAAS : {maas}");
        }

        public class Sirket
        {
            List<personel> personeller = new List<personel>();

            public void personeEkle(personel yeniPersonel)
            {
                personeller.Add(yeniPersonel);
                Console.WriteLine($"{yeniPersonel.isim} şirkete eklendi.");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
