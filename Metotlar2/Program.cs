using System;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama();
            Toplama();
            Toplama();
            Toplama();
            var result = Toplama2(20, 30);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 200;
            var result2 = RefKeyword(ref number1,number2);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        //Parametresiz yani direk bir yazı yazdırma veya bir işlem yaptırma için kullanılan metot şekli aşağıdaki gibidir..
        static void Toplama() 
        {
            Console.WriteLine("Toplama işlemi yapıldı.!");
        }
        //Parametre kullanarak bir hesaplama yaptırıp sonucu gösteren metot şekli aşağıdaki gibidir..
        //static void olarak değil static int veya static string vb. şeklinde tanımlamaya başlayarak parantez içine parametreler verilir.
        //yapılan işlemin türünü bilmediğimiz zamanlarda var türünde bir değişken tanımlanıp işlemin sonucu bu değişkene atılır.
        //return komutuyla yapılan işlemin sonucu geri döndürülür ve metotu programımızda çağıracağımız zaman geri dönen sonucun türünü bilmediğimiz
        //için program satırında var türünde bir değişken tanımlanıp çağırılan metot bu değişkene atanır ve ekrana bu değişken yazdırılır...
        //örnek : kod satırı 13 ve 14....
        static int Toplama2(int number1,int number2) 
        {
            var result = number1 + number2;
            return result;
        }
        //Program satırında referans tip veriyi değer tip veriye göndermek için Ref Keyword kullanırız...
        static int RefKeyword(ref int number1, int number2)
        {
            number1 = 50;
            return number1 + number2;
        }
    }
}
