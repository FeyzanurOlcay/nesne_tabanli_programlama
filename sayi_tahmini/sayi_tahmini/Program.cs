using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_tahmini
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0,100);

            int hak = 5;

            Console.WriteLine("1-100 arasında bir sayı seçiniz: (5 tahmin hakkınız var )");
       

            while (true) 
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < sayi )
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                
                }
                else if ( tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                    
                }
                else if(tahmin == sayi)
                {
                    Console.WriteLine("Teblikler! Doğru tahmin.");
                    break;
                }


                hak--; 

                if (hak == 0) 
                {
                    Console.WriteLine("Hakkınız bitti. Doğru sayı: " + sayi);
                    break;
                }
                else
                {
                    Console.WriteLine($"Kalan hakkınız: {hak}");
                }
            }

            Console.ReadLine();




        }
    }
}
