using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerName ="Furkan";
            customer1.custonmerSurname ="ÇERİ";
            customer1.customerPhoneNumber ="+90(555)555 55 55";
            customer1.customerEmail ="furkancerii2@gmail.com";
            customer1.customerAge =26;
            customer1.customerBalance =47.549;

            Customer customer2 = new Customer();
            customer2.customerName = "Ahmet";
            customer2.custonmerSurname = "KOLCU";
            customer2.customerPhoneNumber = "+90(444)444 44 44";
            customer2.customerEmail = "ahmetkolcu@gmail.com";
            customer2.customerAge = 16;
            customer2.customerBalance = 479.549;

            Customer customer3 = new Customer();
            customer3.customerName = "Aslı";
            customer3.custonmerSurname = "SÜZEN";
            customer3.customerPhoneNumber = "+90(333)333 33 33";
            customer3.customerEmail = "aslisuzen@gmail.com";
            customer3.customerAge = 19;
            customer3.customerBalance = 9.549;

            Customer customer4 = new Customer();
            customer4.customerName = "Burak";
            customer4.custonmerSurname = "AHTAPOT";
            customer4.customerPhoneNumber = "+90(222)222 22 22";
            customer4.customerEmail = "burakahtapotn@gmail.com";
            customer4.customerAge = 42;
            customer4.customerBalance = 80.549;
            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4};
            MusteriManager customerManager = new MusteriManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerList(customers);
            Console.WriteLine();
        }
    }
}
