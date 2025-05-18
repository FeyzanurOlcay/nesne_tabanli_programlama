using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_yonetim_sistemi
{
    public class Kitap
    {
        public string kitap_adi { get; set; }
        public string yazar { get; set; }
        public bool mevcut { get; private set; }
        public double kira_ucret { get; set; }

        public Kitap(string kitapAdi, string Yazar, double kiraUcret)
        {
            kitap_adi = kitapAdi;
            yazar = Yazar;
            kira_ucret = kiraUcret;
            mevcut = true;
        }

        public bool OduncVer()
        {
            if (mevcut)
            {
                mevcut = false;
                return true;
            }
            return false;
        }

        public void Iade()
        {
            mevcut = true;
        }

        public void BilgiGoster()
        {
            string durum = mevcut ? "Ödünçte" : "Mevcut";
            Console.WriteLine($"{kitap_adi} - {yazar} - ({durum}) - Kiralama Ücreti:{kira_ucret} TL");
        }
    }

    public class Uyeler
    {
        public string KisiAd;
        public string KisiSoyad;
        private double bakiye;
        private List<Kitap> oduncKitap;

        public Uyeler(string kisiAd, string kisiSoyad, double Bakiye)
        {
            KisiAd = kisiAd;
            KisiSoyad = kisiSoyad;
            bakiye = Bakiye;
            oduncKitap = new List<Kitap>();
        }

        public void ParaEkle(double miktar)
        {
            if (miktar > 0)
            {
                bakiye += miktar;
                Console.WriteLine($"{miktar} TL eklendi.");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.Tekrar deneyin");
            }
        }
        public void BakiyeGoster()
        {
            Console.WriteLine($"{KisiAd} {KisiSoyad} - Mevcut bakiye: {bakiye} TL");
        }


        public bool KitapOduncAl(Kitap kitap)
        {
            if (bakiye >= kitap.kira_ucret)
            {
                if (kitap.OduncVer())
                {
                    bakiye -= kitap.kira_ucret;
                    oduncKitap.Add(kitap);
                    Console.WriteLine($"{kitap.kitap_adi} kitabı ödünç alındı. Kalan bakiye : {bakiye} TL");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{kitap.kitap_adi} kıtabı zaten ödünçte.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
                return false;
            }
        }

        public void kitapIadeEt(Kitap kitap)
        {
            if (oduncKitap.Contains(kitap))
            {
                kitap.Iade();
                oduncKitap.Remove(kitap);
                Console.WriteLine($"{kitap.kitap_adi} kitabı iade edildi");
            }

        }
    }

    public class Kutuphane
    {
        private List<Kitap> kitaplar;
        private List<Uyeler> uyeler;

        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
            uyeler = new List<Uyeler>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine($"{kitap.kitap_adi} Kitabı eklendi.");
        }
        public void KitaplariListele()
        {
            Console.WriteLine("Mevcut Kitaplar:");
            foreach (var kitap in kitaplar)
            {
                kitap.BilgiGoster();
            }
        }

        public void UyeEkle(Uyeler uye)
        {
            uyeler.Add(uye);
            Console.WriteLine($"{uye.KisiAd} {uye.KisiSoyad} eklendi.");
        }

        public void UyeleriListele()
        {
            Console.WriteLine("Mevcut Üyeler:");
            foreach (var uye in uyeler)
            {
                Console.WriteLine($"{uye.KisiAd} {uye.KisiSoyad}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            Kitap kitap1 = new Kitap("Suç ve Ceza", "Dostoyevski", 20);
            Kitap kitap2 = new Kitap("Kuyucaklı Yusuf", "Sabahattin Ali", 15);

            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            Console.WriteLine();

            Uyeler uye1 = new Uyeler("Nur ", "Yılmaz", 10);
            Uyeler uye2 = new Uyeler("Ali ", "Yıldırım", 20);

            kutuphane.UyeEkle(uye1);
            kutuphane.UyeEkle(uye2);
            Console.WriteLine();
            kutuphane.KitaplariListele();
            Console.WriteLine();
            kutuphane.UyeleriListele();
            Console.WriteLine();
            uye1.ParaEkle(30);
            uye1.BakiyeGoster();
            uye1.KitapOduncAl(kitap1);
            uye2.KitapOduncAl(kitap1);
            uye1.kitapIadeEt(kitap1);
            Console.ReadLine();


        }
    }
}
