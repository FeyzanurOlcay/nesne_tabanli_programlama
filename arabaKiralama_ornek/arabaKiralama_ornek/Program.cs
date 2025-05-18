using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabaKiralama_ornek
{
    class Araba
    {
        public string model;
        public string marka;
        public double kiraUcret;
        public bool kiralanabilirMi;

        public Araba(string marka, string model, double kiraUcret)
        {
            this.model = model;
            this.marka = marka;
            this.kiraUcret = kiraUcret;
            kiralanabilirMi = true;
        }

        public void kirala()
        {
            if(kiralanabilirMi)
            {
                kiralanabilirMi = false;
                Console.WriteLine($"{marka} {model} Kiralanabilir.");
            }
            else
            {
                Console.WriteLine($"Zaten kiralanmış");
            }
        }

        public void bilgiGoster()
        {
            Console.WriteLine("ARAÇ BİLGİLERİ");
            Console.WriteLine($"Araba marka : {marka}");
            Console.WriteLine($"Araba model : {model}");
            Console.WriteLine($"Araba kira ücret : {kiraUcret}");
            Console.WriteLine($"Araba kiralama durumu  : {kiralanabilirMi}");
            Console.WriteLine();
        }

        public void teslimEt()
        {
            if (!kiralanabilirMi)
            {
                kiralanabilirMi=true;
                Console.WriteLine($"{marka} {model} başarıyla teslim edildi.");
            }
            else
            {
                Console.WriteLine($"{marka} {model} kiralanabilir durumda");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("BMW", "320i", 500);
            Araba araba2 = new Araba("AUDİ", "i20", 400);

            araba1.kirala();
            araba1.kirala();

           araba1.teslimEt();

            araba1.bilgiGoster ();
            araba2.bilgiGoster();

            Console.ReadLine();

        }
    }
}
