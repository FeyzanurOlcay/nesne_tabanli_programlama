using System;
using System.IO;

namespace AlisverisUygulamasi
{
    class Program
    {
        static string file = "aliveris_listesi.txt"; // Global dosya
        static bool kontrol = true; // Döngü kontrolü

        static void Main(string[] args)
        {
            // Menü ve işlemleri başlat
            while (kontrol)
            {
                Console.WriteLine("-- Alışveriş Listesi --");
                Console.WriteLine("1 - Ürün Ekle");
                Console.WriteLine("2 - Ürün Listele");
                Console.WriteLine("3 - Liste Temizle");
                Console.WriteLine("4 - Çıkış");

                Console.Write("Bir işlem seçiniz: ");
                string secim = Console.ReadLine();

                // Seçime göre işlemleri yönlendir
                switch (secim)
                {
                    case "1":
                        UrunEkle(); // Ürün ekleme
                        break;
                    case "2":
                        UrunListele(); // Ürün listeleme
                        break;
                    case "3":
                        ListeTemizle(); // Liste temizleme
                        break;
                    case "4":
                        CikisYap(); // Çıkış
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void UrunEkle()
        {
            Console.WriteLine("Eklemek istediğiniz ürünleri giriniz (Çıkmak için 'ç' yazın):");
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                while (true)
                {
                    string urun = Console.ReadLine();
                    if (urun.ToLower() == "ç")
                    {
                        Console.WriteLine("Ürünler başarıyla eklendi.");
                        break;
                    }
                    sw.WriteLine(urun);
                }
            }
        }

        static void UrunListele()
        {
            if (File.Exists(file))
            {
                string[] urunler = File.ReadAllLines(file);
                Console.WriteLine("\n---- Alışveriş Listesi ----");
                foreach (var urun in urunler)
                {
                    Console.WriteLine(urun);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liste boş, önce ürün ekleyin.");
            }
        }

        static void ListeTemizle()
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                Console.WriteLine("Liste temizlendi.");
            }
            else
            {
                Console.WriteLine("Liste zaten boş.");
            }
        }

        static void CikisYap()
        {
            Console.WriteLine("Çıkış yapılıyor...");
            kontrol = false;
        }
    }
}




