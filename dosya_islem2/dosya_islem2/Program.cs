using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Data.SqlTypes;


namespace dosya_islem2
{
    internal class Program
    {
        class Person
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int yas { get; set; }
            public List<string> hobiler { get; set; }
        }
        static void Main(string[] args)
        {
            /*    var Person = new
                {
                    ad = "Ahmet",
                    soyad = "Yılmaz",
                    yas = 23,
                    hobiler = new [] {"Yüzme","kitap okuma","satranç" }

                };
                string filePath = "person.json";
                string jsonn = JsonSerializer.Serialize(Person,new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonn);*/

            string filePath = "person.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                var person = JsonSerializer.Deserialize<Person>(jsonString);

                Console.WriteLine("Json dosyasından okunan veriler :");
                Console.WriteLine($"Ad :{person.ad}");
                Console.WriteLine($"Soyad :{person.soyad}");
                Console.WriteLine($"Yaş :{person.yas}");

                foreach (var hobi in person.hobiler)
                {
                    Console.WriteLine($"- {hobi}");
                }
            }
            else
            {
                Console.WriteLine("Hata : Dosya bulunamadı !");
            }

            Console.ReadLine();
        }
    }
}
