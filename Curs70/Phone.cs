using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs70
{
    public class Phone
    {
        public string Brand { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public Phone(string brand, string color, int price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }
    }
}
