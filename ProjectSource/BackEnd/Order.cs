using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadanANDAsma.entity
{
    public class Order
    {
        public int ordernum { get; set; }
        public int orderdate { get; set; }
        public int customernum { get; set; }
        public String customername { get; set; }
    }
}