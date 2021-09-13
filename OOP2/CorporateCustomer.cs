using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer : Customer                  // İnheritance
    {
        public string CorporationName { get; set; }
        public string TaxNumber { get; set; }
    }
}
