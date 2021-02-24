using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself!!!(Kendini tekrarlama!!! değişken kullan)
            //type safety (tip güvenliği)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                {
                    Console.WriteLine("Azalış Butonu");
                }
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi==false)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapılmadı");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
