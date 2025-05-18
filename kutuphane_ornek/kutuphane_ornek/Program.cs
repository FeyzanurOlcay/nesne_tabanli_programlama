using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_ornek
{
    class Kitap
    {
        public string isim;
        public string yazar;
        public string isbn;
        public int sayfa;

        public Kitap(string isim, string yazar, string isbn, int sayfa)
        {
            this.isim = isim;
            this.yazar = yazar;
            this.isbn = isbn;
            this.sayfa = sayfa;
                
        }

        public void bilgiGoster()
        {
            Console.WriteLine($"Kitap adı: {isim}");
            Console.WriteLine($"Kitap yazarı: {yazar}");
            Console.WriteLine($"Kitap isbn: {isbn}");
            Console.WriteLine($"Kitap sayfa sayısı: {sayfa}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap("Sefiller", "Victor Hugo", "123345", 250);
            Kitap kitap2 = new Kitap("Kürk mantolu madonna","Sabahattin Ali", "122222", 200);

            kitap1.bilgiGoster();
            kitap2.bilgiGoster();

            Console.ReadLine();

        }
    }
}
