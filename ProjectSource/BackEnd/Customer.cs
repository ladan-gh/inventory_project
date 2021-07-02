using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadanANDAsma.entity
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName {get;set;}
        public string CustomerLastName {get;set;}
        public string CustomerAddress { get; set; }
        public int CustomerPhoneNumber { get; set; }
    }
}
