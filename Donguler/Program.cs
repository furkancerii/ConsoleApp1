using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //+++++++++++++++++++++

            for (int j = 1; j <=10; j=j+2)
            {
                Console.WriteLine(j);
            }


            for (int j2 = 1; j2 <=10; j2+=2)
            {
                Console.WriteLine(j2);
            }
            //++++++++++++++++++++++
            //artı işaretleri arasına alınmış 2 döngü de aynı işi yapar



            //for döngüsü ile dizi(array) kullanımı...
            string[] kelimeler = new string[]
                {
                    "Merhaba","Nasılsın","Naber"
                };
            for (int i = 0; i <kelimeler.Length; i++)
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.WriteLine("Sayfa Sonu - footer");



            //girilen iki sayıyı büyükten küçüğe doğru yazdıran döngü...
            int number1, number2;
            Console.Write("Birinci sayıyı giriniz : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            number2 = Convert.ToInt32(Console.ReadLine());

                for(int i = number1; i > number2; number2++)
                {
                    Console.WriteLine(number2);
                }

                for (int j = number2; j >= number1; number1++)
                {
                    Console.WriteLine(number1);
                }


            //kullanıcıdan aldığı 10 adet sayıyı toplayarak ekrana yazan döngü...
            int sayi1, toplam;
            toplam = 0;
            for (int i =1; i <=10; i++)
            {
                Console.Write("{0}. sayıyı giriniz. ",i);
                sayi1 = Convert.ToInt32(Console.ReadLine());
                toplam += sayi1;
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı : {0} ",toplam);

            //Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran döngü...
            int sayi2, sonuc;
            sonuc = 1;
            for (int i = 1; i <=10; i++)
            {
                Console.Write("{0}. sayıyı giriniz. ",i);
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if ((sayi2>0) && (sayi2%2==1))
                {
                    sonuc *= sayi2;
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);


            //Yüksekliği ve genişliği kullanıcı tarafından girilen dikdörtgeni ekrana çizen döngü...
            Console.Write("Yüksekliği Girin : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişliği Girin : ");
            int genislik = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= genislik; j++)
                {
                    if (i == 1 || i == yukseklik)
                        Console.Write("*");
                    else
                        if (j == 1 || j == genislik)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }
}
