using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added!");
        }

        public void Listed(Customer customer)
        {
            Console.WriteLine("Customer Listed!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted!");
        }
    }
}
