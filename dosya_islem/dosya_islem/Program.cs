using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dosya içeriği okuma -- READTOEND METODU 
            /* string filePath = "example.txt";
              using(StreamReader reader = new StreamReader(filePath))
              {
                string content = reader.ReadToEnd(); // tüm dosyayı aynı anda belleğe yükler sıkıntı yaratabilir .
                  Console.WriteLine("Dosya içeriği :\n");
                  Console.WriteLine(content);
              }*/


            //dosya okuma - READLİNE METODU -- büyük dosyalar için daha uygun
             string file = "example.txt";
             using(StreamReader reader1 = new StreamReader(file))
             {
                 Console.WriteLine("Dosya içeriği :");
                 string line;
                 while((line = reader1.ReadLine()) != null)
                 {
                     Console.WriteLine(line);
                     // readline streamReader sınıfının metodudur
                     // ve okunacak satır kalmadığında null döner bu yüzden döngüde her seferinde null dönüp dönmediğini kontrol ediyoruz .
                     // readtoend metoduna göre çok hafiftir ve satır satır okur.
                 }
             }


            // dosya okuma --READALLLİNES METODU -- küçük dosyalar için uygun
            /*  string filePath = "example.txt";
              string[] readLines = File.ReadAllLines(filePath); // Satır satır okumak yerine tüm dosya içeriğini belleğe yükler ve satırları ayrı ayrı elemanlar olarak bir diziye yerleştirir.
              Console.WriteLine("Dosya içeriği :");
              foreach (var line in readLines)
              {
                  Console.WriteLine(line);
              }*/



            // dosya yazma ve oluşturma 
            /*using (StreamWriter writer = new StreamWriter(filePath))
            StreamWriter sınıfı, yazma işlemleri için kullanılır.Bu satır, dosyayı açar(veya yeni dosya oluşturur)
            ve içine yazma işlemi yapabilmek için writer nesnesini oluşturur.
            Eğer dosya zaten varsa, içeriği üzerine yazar. Eğer yoksa, yeni bir dosya oluşturur.

            string filePath = "example.txt";
            using (StreamWriter writer = new StreamWriter(filePath))// append : true))-- dosyadaki verileri silmeyip üzerine ekler.eğer append eklenmezse verileri siler.
            {
                writer.WriteLine("Sana olan aşkım ebedi");
                writer.WriteLine("Kimseyi sevemem oldun sebebim");
                writer.WriteLine("Yanık olduğum gözlerine");
                writer.WriteLine("Başkası bakamaz olurum sebebi");
                writer.WriteLine("Hatırlarsın sözlerimi, bir gün gelicek sarıcam belini");
                writer.WriteLine("Unuturum derdi kederi, ah tutsam sıcacık ellerini");

                Console.WriteLine("Başarıyla eklendi..");

            }
            */


            // dosya yazma -- File.WriteAllText(), belirtilen dosya yoluna metin yazar.
            // Eğer dosya zaten varsa, içeriğini tamamen siler ve yeni metni yazar.
            /* string filePath = "example.txt";
             string content = "Seni yar diye koynuma aldığımdan beri korkardım gideceğinden.\n Şimdi yar nerede hani yar nerede diye düşer oldum pencerelerden";
             File.WriteAllText(filePath, content);
             Console.WriteLine("başarıyla eklendi");*/


            // dosya mevcut mu diye kontrol edilir

            /* string filePath = "example1.txt";
             if(File.Exists(filePath))
             {
                 Console.WriteLine("Dosya mevcut");
             }
             else
             {
                 Console.WriteLine("Dosya bulunamadı.Yeni bir dosya oluşturuluyor...");
                 File.WriteAllText(filePath, "Bu bir örnek dosyadır.");
             }*/



            /*
            //klasör / dizin olup olmadığını kontrol edip oluşturmak.
            string directoryPath = "example_directory";
            if (!Directory.Exists(directoryPath))  // Dizin var mı diye kontrol etmelisin
            {
                Console.WriteLine("Dizin bulunamadı. Yeni bir dizin oluşturuluyor...");
                Directory.CreateDirectory(directoryPath);  // Dizin oluşturuluyor
              
            }
            else
            {
                Console.WriteLine("Dizin mevcut");
            }
            */


            // Path.Combine, verilen klasör yolunu ve dosya adını birleştirerek tam bir dosya yolu oluşturur.
            // hatalı birleşimleri önler doğru şekilde yol oluşturmayı sağlar

            /* string directoryPath = "example_directory";
             string fileName = "example.txt";

             string fullPath = Path.Combine(directoryPath, fileName);
             Console.WriteLine("Birleştirilen yol :"+ fullPath); */



            // dosya ve klasör yolunu  doğru şekilde ayırmak için kullanıyoruz.
            /* string fullPath = "C:\\Users\\Feyzanur\\OneDrive\\Masaüstü\\dosyalarım\\deneme.txt";
             Console.WriteLine("dizin adı :" + Path.GetDirectoryName(fullPath));
             Console.WriteLine("dosya adı :"+ Path.GetFileName(fullPath));*/


            // Path.ChangeExtension, dosya adını otomatik olarak değiştirmeye olanak tanır.
            // dosya yolunu değiştirmeye yarar
            /* string file = "example.txt";
             Console.WriteLine("Dosya uzantısı :" + Path.GetExtension(file));
             string newPath = Path.ChangeExtension(file, ".pdf");
             Console.WriteLine("Yeni uzantı :"+ newPath);*/


            // Path.GetFullPath, dosyaların tam yollarını elde etmek için kullanılır 
            /*  string fullpath = "example.txt";
              string newpath = Path.GetFullPath(fullpath);
              Console.WriteLine("Yeni uzantı  :"+ newpath);*/
            Console.ReadLine();
        }
    }
}

