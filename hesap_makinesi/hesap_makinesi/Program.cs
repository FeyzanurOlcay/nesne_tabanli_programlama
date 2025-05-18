using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class hesapMakinesi
    {
        public double Topla(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public double Cikar(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public double Carp(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public double Bol(double sayi1, double sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Hata : Sıfıra bölünemez !!");
                return 0;
            }
            double sonuc = sayi1 / sayi2;
            return sonuc;
        }
    }
    internal class Program
    {
        static void islem()
        {

            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("ç - Çıkış");
        }

        static void Main(string[] args)
        {
            hesapMakinesi hesap = new hesapMakinesi();

            while (true)
            {
                Console.WriteLine("\nİşlem Seçin:");
                islem();
                string secim = Console.ReadLine();


                if (secim.ToLower() == "ç")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }

                bool islemMi = true;
                double sonuc = 0;

                if (secim == "1" || secim == "2" || secim == "3" || secim == "4")
                {
                    Console.Write("Birinci sayıyı giriniz: ");
                    double sayi = Convert.ToDouble(Console.ReadLine());
                    Console.Write("İkinci sayıyı giriniz: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());

                    switch (secim)
                    {
                        case "1":
                            sonuc = hesap.Topla(sayi, sayi2);
                            break;
                        case "2":
                            sonuc = hesap.Cikar(sayi, sayi2);
                            break;
                        case "3":
                            sonuc = hesap.Carp(sayi, sayi2);
                            break;
                        case "4":
                            sonuc = hesap.Bol(sayi, sayi2);
                            break;


                    }
            

                }
                else
                {
                    Console.WriteLine("Geçersiz işlem! Lütfen geçerli bir işlem seçin.");
                    islemMi = false;
                }

              
                if (islemMi)
                {
                    Console.WriteLine("SONUÇ: " + sonuc);
                }
            }
        }
    }
}
