using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba_model
{
    class Araba // sınıfı oluşturuyoruz
    {
        public string marka; // sınıf ve nesne içinde kullanacağımız değişkenleri tanımlıyoruz. 
        public string model;// public: Sınıfın dışından da erişilebilir.( erişim belirleyicidir)
        private int hiz = 200; // private: sadece sınıf içerisinde erişilebilir.


        //calistir metodu , araba nesnesi çalıştığında ne yapılacağını tanımlar.
        public void calistir()
        {
            Console.WriteLine($"{marka}, {model}, {hiz}");
        }

        // Private olan hız değişkenine erişim sağlayan metod (getter)
        public int GetHiz()
        {
            return hiz;
        }

        // Private olan hız değişkenini güncelleyen metod (setter)
        public void SetHiz(int yeniHiz)
        {
            hiz = yeniHiz;  // hiz değişkenine yeni bir değer atanır
        }

    }
    internal class Program
    {
        // programın giriş noktası olan main metodu
        static void Main(string[] args)
        {
            // nesne oluşturma
            Araba araba1 = new Araba();
            araba1.marka = "BMW";
            araba1.model = "320i";
            araba1.calistir();

            Console.WriteLine("Başlangıç Hızı: " + araba1.GetHiz());

            // Hızı 250 olarak güncelle
            araba1.SetHiz(250);

            // Güncellenmiş hızı ekrana yazdır
            Console.WriteLine("Güncellenmiş Hız: " + araba1.GetHiz());

            // Arabayı çalıştır ve bilgilerini yazdır


            araba1.calistir();
            Console.ReadLine();

            //Getter metodu, bir sınıfın özel değişkenini dışarıya okumak için kullanılır.
            //private olarak tanımlanmış bir alanı, dışarıdan sadece metot aracılığıyla erişilebilir hale getirir.
            //Getter'lar değeri geri döndürür, ancak bu değeri değiştirmezler.


            //Setter metodu, bir sınıfın özel değişkenini değiştirmek için kullanılır.
            //  Dışarıdan parametre olarak aldığı değeri, sınıfın içindeki private bir alanına atar.
            //  Bu metotla dışarıdan gelen değeri kontrol edebilir, istenmeyen verilerin atanmasını engelleyebiliriz(örneğin, negatif hız değeri).

        }
    }
}
