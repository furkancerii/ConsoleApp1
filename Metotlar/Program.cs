using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prodcut1 = new Product();
            prodcut1.Name ="Elma";
            prodcut1.Price =15;
            prodcut1.Explanation ="Amasya elması";

            Product product2 = new Product();
            product2.Name ="Karpuz";
            product2.Price =80;
            product2.Explanation ="Diyarbakır karpuzu";

            Product[] products = new Product[] {prodcut1,product2};
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("------------------METOTLAR---------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(prodcut1);
            sepetManager.Ekle(product2);
        }
    }
}
