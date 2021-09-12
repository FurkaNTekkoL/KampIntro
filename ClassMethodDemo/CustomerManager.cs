using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id +" " + "Id is Added");
        }

        public void Listed(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + "FirstName is Listed");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " " + "CustomerId is Deleted!");
        }
    }
}
