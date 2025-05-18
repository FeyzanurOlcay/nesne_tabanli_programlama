using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahmin_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(1,100);

            Console.WriteLine("1 ile 100 arasından bir sayı seçiniz.");
           
            for (int i = 1; i < 100; i++)
            {
                Console.Write("Tahmininiz: ");
                int tahmin =Convert.ToInt32(Console.ReadLine());

                if(tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                }
                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                }
                if(tahmin == sayi)
                {
                    Console.WriteLine("Tebrikler!" + i + " denemede tahmin ettiniz.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
