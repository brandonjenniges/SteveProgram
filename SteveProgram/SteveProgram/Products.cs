using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherBlock
{
    class Product
    {
        private string name;
        private int id;
        private double price;

        public Product()
        {
        }

        public Product(int  p_id, string p_name, double p_price)
        {
            name = p_name;
            id = p_id;
            price = p_price;
        }

        public double getPrice()
        {
            return price;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }
    }
}
