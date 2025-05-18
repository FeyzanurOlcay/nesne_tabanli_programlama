using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace banka_ornek
{
    public class BankaHesabi
    {
        public string hesapSahibi;
        public int hesapNo;
        public double bakiye;
        private static int hesapSayisi;


        public BankaHesabi(string hesapSahibi, double ilkBakiye)
        {
            this.hesapSahibi = hesapSahibi;
            this.bakiye = ilkBakiye;
            this.hesapNo = ++hesapSayisi;
        }

        public void paraCek(double miktar)
        {
            if (miktar <= bakiye)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL hesabınızdan çekildi.");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }

        public void paraYatır(double miktar)
        {
            if (miktar > 0)
                bakiye += miktar;
            Console.WriteLine($"{miktar} TL hesabınıza yatırıldı.");
        }

        public void bilgiGoster()
        {
            Console.WriteLine("HESAP BİLGİLERİ");
            Console.WriteLine($"Hesap numarası : {hesapNo}");
            Console.WriteLine($"Hesap sahibi : {hesapSahibi}");
            Console.WriteLine($"Hesap bakiyesi : {bakiye}");

        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi hesap1 = new BankaHesabi("Feyzanur", 2300);
            BankaHesabi hesap2 = new BankaHesabi("Nur", 1250);

            bool kontrol = true;

            while (kontrol)
            {
                islemMenu();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        hesap1.bilgiGoster();
                        hesap2.bilgiGoster();
                        break;
                    case "2":
                        Console.WriteLine("Çekmek istediğiniz tutarı giriniz :");
                        double tutar = Convert.ToInt32(Console.ReadLine());
                        hesap1.paraCek(tutar);
                        hesap1.bilgiGoster();
                        break;
                    case "3":
                        Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
                        double tutar2 = Convert.ToInt32(Console.ReadLine());
                        hesap1.paraYatır(tutar2);
                        hesap1.bilgiGoster();
                        break;
                    case "4":
                        kontrol = false;
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim tekrar deneyin.");
                        break;
                }

            }










  

        }
        static void islemMenu()
        {
            Console.WriteLine("Bir işlem seçiniz :");
            Console.WriteLine("1 - Hesap Bilgileri :");
            Console.WriteLine("2 - Para Çek :");
            Console.WriteLine("3 - Para Yatır :");
            Console.WriteLine("4 - Çıkış :");
        }


    }
}
