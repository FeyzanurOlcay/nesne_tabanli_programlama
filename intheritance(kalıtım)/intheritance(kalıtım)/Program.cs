using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intheritance_kalıtım_
{
    public class hayvan
    {
        public string isim;
        public string cinsiyet;
        public int yas;

        public void bilgiGoster()
        {
            Console.WriteLine("Hayvan bilgileri :"  );
            Console.WriteLine($"İsim : {isim} --Cinsiyet :{cinsiyet} --Yaş : {yas}");
        }
    }
    public class kedi : hayvan
    {
        public string renk;

        public void kedi_sesi()
        {
            Console.WriteLine("Miyav");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kedi kedi = new kedi();
            kedi.isim = "boncuk";
            kedi.cinsiyet = "dişi";
            kedi.renk = "beyaz";
            kedi.yas = 2;
            kedi.bilgiGoster();
            kedi.kedi_sesi();

            Console.ReadLine();
        }
    }
}
