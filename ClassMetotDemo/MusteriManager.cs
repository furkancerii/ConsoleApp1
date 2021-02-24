using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(" Müşteri adı      :"+customer.customerName);
            Console.WriteLine(" Müşteri soyadı   :" + customer.custonmerSurname);
            Console.WriteLine(" Müşteri yaşı     :"+customer.customerAge);
            Console.WriteLine(" Müşteri e-mail   :" + customer.customerEmail);
            Console.WriteLine(" Müşteri Tel.No   :" + customer.customerPhoneNumber);
            Console.WriteLine(" Müşteri bakiyesi :"+customer.customerBalance);
            Console.WriteLine();
            Console.WriteLine("Müşteri bilgileri sisteme eklenmiştir.");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(" Müşteri adı      :" + customer.customerName);
            Console.WriteLine(" Müşteri soyadı   :" + customer.custonmerSurname);
            Console.WriteLine(" Müşteri yaşı     :" + customer.customerAge);
            Console.WriteLine(" Müşteri e-mail   :" + customer.customerEmail);
            Console.WriteLine(" Müşteri Tel.No   :" + customer.customerPhoneNumber);
            Console.WriteLine(" Müşteri bakiyesi :" + customer.customerBalance);
            Console.WriteLine();
            Console.WriteLine("Müşteri bilgileri sistemden silinmiştir.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
        public void CustomerList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(" Müşteri adı      :" + customer.customerName);
                Console.WriteLine(" Müşteri soyadı   :" + customer.custonmerSurname);
                Console.WriteLine(" Müşteri yaşı     :" + customer.customerAge);
                Console.WriteLine(" Müşteri e-mail   :" + customer.customerEmail);
                Console.WriteLine(" Müşteri Tel.No   :" + customer.customerPhoneNumber);
                Console.WriteLine(" Müşteri bakiyesi :" + customer.customerBalance);
                Console.WriteLine();
                Console.WriteLine("Müşteri bilgileri listesi.");
                Console.WriteLine("--------------------------");
                Console.WriteLine();
            }
        }
    }
}
