using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer : Customer
    {
        public string IdentificationNumber { get; set; }     // Bazı sayısal ifadeleri string tanımlamamızın amacı değişmeyen numaralar olmasıdır.
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
