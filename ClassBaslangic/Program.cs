using System;

namespace ClassBaslangic
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { };
            product1.productName = "Monster Abra v5";
            product1.productPrice = 9800;

            Product product2 = new Product { };
            product2.productName = "MacBook Air";
            product2.productPrice = 13000;

            Product product3 = new Product { };
            product3.productName = "iMac 27''";
            product3.productPrice = 17000;

            Product[] product = new Product[] {product1,product2,product3 };
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Foreach Döngüsü");
            Console.WriteLine("________________________________________________");
            
            foreach (Product products in product)
            {
                Console.WriteLine(" Ürün adı :" + products.productName + " " + " Ürün Fiyatı :" + products.productPrice);
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________");
            
            Console.WriteLine("For Döngüsü");
            Console.WriteLine("________________________________________________");
            
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(" Ürün adı :" + product[i].productName + " " + " Ürün Fiyatı :" + product[i].productPrice);
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________");
            
            Console.WriteLine("While Döngüsü");
            Console.WriteLine("________________________________________________");
            
            int j =0;
            while (j < product.Length)
            {
                Console.WriteLine(" Ürün adı :" + product[j].productName + " " + " Ürün Fiyatı :" + product[j].productPrice);
                
                Console.WriteLine();
                j++;
            }
            Console.WriteLine("________________________________________________");
            




            //Students student1 = new Students { };
            //student1.studentName = "Ayşe";
            //student1.examScore = 30;

            //Students student2 = new Students { };
            //student2.studentName = "Ahmet";
            //student2.examScore = 10;

            //Students student3 = new Students { };
            //student3.studentName = "Furkan";
            //student3.examScore = 100;

            //Students student4 = new Students { };
            //student4.studentName = "Yahya";
            //student4.examScore = 70;

            //Students student5 = new Students { };
            //student5.studentName = "Selma";
            //student5.examScore = 50;

            //Students student6 = new Students { };
            //student6.studentName = "Elif";
            //student6.examScore = 90;

            //Students[] student = new Students[] {student1,student2,student3,student4,student5,student6 };
            //int minscore = 50;            

            //for (int i = 0; i <student.Length; i++)
            //{

            //    string durum = (student1.examScore < minscore) ? "Öğrenci adı :"+student1.studentName+
            //        " | "+" Sınav sonucu :"+student1.examScore+" | "+" Başarı durumu : Başarısız": "Öğrenci adı :"
            //        + student1.studentName + " | " + " Sınav sonucu :" + student1.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum);
            //    string durum2 = (student2.examScore < minscore) ? "Öğrenci adı :" + student2.studentName +
            //        " | " + " Sınav sonucu :" + student2.examScore + " | " + " Başarı durumu : Başarısız" : "Öğrenci adı :" 
            //        + student2.studentName + " | " + " Sınav sonucu :" + student2.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum2);

            //    string durum3 = (student3.examScore < minscore) ? "Öğrenci adı :" + student3.studentName +
            //        " | " + " Sınav sonucu :" + student3.examScore + " | " + " Başarı durumu : Başarısız" : "Öğrenci adı :"
            //        + student3.studentName + " | " + " Sınav sonucu :" + student3.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum3);
            //    string durum4 = (student4.examScore < minscore) ? "Öğrenci adı :" + student4.studentName + 
            //        " | " + " Sınav sonucu :" + student4.examScore + " | " + " Başarı durumu : Başarısız" : "Öğrenci adı :"
            //        + student4.studentName + " | " + " Sınav sonucu :" + student4.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum4);
            //    string durum5 = (student5.examScore < minscore) ? "Öğrenci adı :" + student5.studentName +
            //        " | " + " Sınav sonucu :" + student5.examScore + " | " + " Başarı durumu : Başarısız" : "Öğrenci adı :"
            //        + student5.studentName + " | " + " Sınav sonucu :" + student5.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum5);
            //    string durum6 = (student6.examScore < minscore) ? "Öğrenci adı :" + student6.studentName + 
            //        " | " + " Sınav sonucu :" + student6.examScore + " | " + " Başarı durumu : Başarısız" : "Öğrenci adı :" 
            //        + student6.studentName + " | " + " Sınav sonucu :" + student6.examScore + " | " + " Başarı durumu :Başarılı";

            //    Console.WriteLine(durum6);


            //    break;
            //}



            //Game games1 = new Game { };
            //games1.GameId = 1;
            //games1.GameName ="Kerbal Space Program";
            //games1.GameStock =10.675;
            //games1.GamePrice =10.99;

            //Game games2 = new Game { };
            //games2.GameId =2;
            //games2.GameName ="Crusader Kings 3";
            //games2.GameStock =142.348;
            //games2.GamePrice =23.99;

            //Game games3 = new Game { };
            //games3.GameId =3;
            //games3.GameName ="Hearts Of Iron IV";
            //games3.GameStock =65.874;
            //games3.GamePrice =15.99;

            //Game[] games = new Game[] { games1,games2,games3};

            //foreach (Game game in games)
            //{
            //    Console.WriteLine(game.GameId+" : "+game.GameName+" | "+" Stoktaki Adet : "+game.GameStock+" | "+" Fiyat : "+game.GamePrice);
            //}

            //// Oluşturduğumuz classı bir değişkene tanımlayıp classın içindeki verileri oluşturma şeklimiz aşağıdaki gibidir...
            //Kurs kurs1 = new Kurs();
            //kurs1.KursAdi ="C#";
            //kurs1.Egitmen ="Engin Demiroğ";
            //kurs1.IzlenmeOrani =68;



            //Kurs[] kurslar = new Kurs[] {kurs1};  //dizi

            //foreach (var kurs in kurslar)
            //{
            //    Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            //}
        }
    }


    //Classımızı oluşturma şeklimiz aşağıdaki gibidir...
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

    class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GameStock { get; set; }
        public double GamePrice { get; set; }
    }
    class Students
    {
        public string studentName { get; set; }
        public int examScore { get; set; }
    }
    class Product 
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }
}
