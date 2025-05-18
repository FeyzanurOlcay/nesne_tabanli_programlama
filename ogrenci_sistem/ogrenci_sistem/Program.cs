using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci_sistem
{
    public class Ogrenci
    {
        private int no;
        private string isim;
        private string soyisim;
        private string okulAdi;
        private int vize1;
        private int vize2;
        private int final;

        public Ogrenci(int _no, string _ad, string _soyad, string _okulAdi, int _vize1, int _vize2, int _final)
        {
            no = _no;
            isim = _ad;
            soyisim = _soyad;
            okulAdi = _okulAdi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
        }

        public void bilgiGoster()
        {
            Console.WriteLine("Öğrenci numarası :" + no);
            Console.WriteLine("Öğrenci isim :" + isim);
            Console.WriteLine("Öğrenci soyisim :" + soyisim);
            Console.WriteLine("Öğrenci okulu :" + okulAdi);
            Console.WriteLine("Öğrenci vize1 :" + vize1);
            Console.WriteLine("Öğrenci vize2 :" + vize2);
            Console.WriteLine("Öğrenci final :" + final);
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okuduğu okul : " + okulAdi);
        }

        public double ortalama()
        {
            double ort = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return ort;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogr1 = new Ogrenci(123, "Nur", "Olcay", "AHBV", 75, 68, 89);

            Console.WriteLine("Hoşgeldiniz...");

            while (kontrol)
            {
                Console.WriteLine();
                Console.WriteLine("Bir seçim yapınız:");
                islem();
                Console.Write("seçiminiz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogr1.bilgiGoster();
                        break;
                    case "2":
                        ogr1.okulGetir();
                        break;
                    case "3":
                        double ort = ogr1.ortalama();
                        Console.WriteLine("Öğrencinin ortalaması :"+ ort);
                        break;
                    case "4":
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim! Tekrar deneyiniz.");
                        break;
                }
            }

        }
        static void islem()
        {
            Console.WriteLine(" 1 - Öğrenci bilgisini göster");
            Console.WriteLine(" 2 - Öğrenci okulunu göster");
            Console.WriteLine(" 3 - Öğrenci ortalamasını göster");
            Console.WriteLine(" 4 - Çıkış yap");
        }
    }
}
