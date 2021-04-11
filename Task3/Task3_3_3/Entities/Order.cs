using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class Order
    {
        public Pizza Pizza { get; set; }

        public Buyer Buyer { get; set; }
    }
}
