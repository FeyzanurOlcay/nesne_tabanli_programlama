using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_uygulaması
{
    class BankaHesabi //  Bu satır, BankaHesabi adında bir sınıf tanımlıyor.
    {
        public double Bakiye { get; private set; }
        // public erişim belirleyici ile sınıf dışından erişilebilir.
        // Ancak, private set ile sadece bu sınıfın içinde değer ataması yapılabilir.
        // Yani, dışarıdan Bakiye değerini okuyabiliriz ama değiştiremeyiz. Bu, veri gizliliği sağlar.

        public BankaHesabi(double baslangicBakiyesi) 
        {
            Bakiye = baslangicBakiyesi;
        }
      //  Bu bir yapıcı metod(constructor).
      //  Sınıfın bir nesnesi oluşturulurken çalıştırılır.
      //  baslangicBakiyesi parametresi ile kullanıcıdan başlangıç bakiyesini alır ve bu değeri Bakiye özelliğine atar.
      //  Yani, yeni bir BankaHesabi nesnesi oluşturduğumuzda, başlangıç bakiyesini belirlememizi sağlar.

        public void ParaCek(double miktar) // para çekme metodudur.
        {
            if (miktar > Bakiye)
            {
                Console.WriteLine("Yetersiz bakiye");

            }
            else
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye:  {Bakiye} TL");

            }
        }

        public void ParaYatır(double miktar) // para yatırma metodu.
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi hesap = new BankaHesabi(100); // satırı ile yeni bir BankaHesabi nesnesi oluşturuluyor ve başlangıç bakiyesi 100 TL olarak belirleniyor.
            hesap.ParaCek(100);
            hesap.ParaYatır(300);
            Console.ReadKey();
        }
    }
}
