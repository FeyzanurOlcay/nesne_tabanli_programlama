using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Ogrenci
    {
        private int ogrNo;
        private string isim;
        private string soyisim;
        private string okulAdi;
        private int vize1;
        private int vize2;
        private int final;

        public Ogrenci(int _no, string _isim, string _soyisim, string _okulAdi, int _vize1, int _vize2, int _final)
        {
            ogrNo = _no;
            isim = _isim;
            soyisim = _soyisim;
            okulAdi = _okulAdi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
        }

        public void bilgiGoster()
        {
            Console.WriteLine($" Öğrenci Numarası : {ogrNo}");
            Console.WriteLine($" Öğrenci İsim : {isim}");
            Console.WriteLine($" Öğrenci Soyisim : {soyisim}");
            Console.WriteLine($" Öğrenci Okul : {okulAdi}");
            Console.WriteLine($" Öğrenci Vize1 : {vize1}");
            Console.WriteLine($" Öğrenci Vize2 : {vize2}");
            Console.WriteLine($" Öğrenci Final : {final}");
        }

        public double ortalama()
        {
            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okulu : " + okulAdi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogr1 = new Ogrenci(123, "Nur", "Olcay", "Ahbv", 70, 83, 75);


            Console.WriteLine("Hoşgeldiniz...");


            while (kontrol)
            {
                Console.WriteLine();
                Console.WriteLine("Bir işlem seçiniz :");
                islemGoster();
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        ogr1.bilgiGoster();
                        break;
                    case 2:
                        ogr1.okulGetir();
                        break;
                    case 3:
                        double ortalama = ogr1.ortalama();
                        Console.WriteLine("Öğrenci ortalaması :" + ortalama);
                        break;
                    case 4:
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, tekrar deneyiniz.");
                        break;
                }

            }

        }
        static void islemGoster()
        {
            Console.WriteLine("1 - Öğrenci bilgilerini göster");
            Console.WriteLine("2 - Öğrenci okulunu göster");
            Console.WriteLine("3 - Öğrenci ortalamasını bul");
            Console.WriteLine("4 - Çıkış");
        }
    }
}
