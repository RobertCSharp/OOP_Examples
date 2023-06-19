using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs70
{
    public class Car
    {
        private string brand;
        private string color;
        private int price;


        // manual
        public string Brand
        {
            get { return brand; } set { brand = value; }
        }

        public string Color
        {
            get { return color; } set {  color = value; }
        }

        public int Price
        {
            get { return price; } set { price = value; }
        }


    }
}
