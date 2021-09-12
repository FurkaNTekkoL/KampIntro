using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerId = "101";
            customer1.FirstName = "Evren";
            customer1.LastName = "Tekeli";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerId = "102";
            customer2.FirstName = "Faruk";
            customer2.LastName = "Kızıltaş";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerId = "103";
            customer3.FirstName = "Nevbahar";
            customer3.LastName = "Turan";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Listed(customer2);
            customerManager.Delete(customer3);


        }
    }
}
