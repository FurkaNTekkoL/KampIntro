using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.IdentificationNumber = "12345678910";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CorporationName = "Kodlama.io";
            customer2.TaxNumber = "0987654321";


            Customer customer3 = new IndividualCustomer();            // Customer class'ı hem gerçek hemde tüzel kişilerin referansını tutabiliyor.
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
