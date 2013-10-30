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
        private string price_string;

        public Product()
        {
        }

        public Product(int  p_id, string p_name, string p_price)
        {
            name = p_name;
            id = p_id;
            price_string = name.Equals("Deer Processing") ? "$" + p_price : "$" + p_price + "/lb";
            price = Convert.ToDouble(p_price);
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public double getPriceValue()
        {
            return price;
        }

        public string getPriceString()
        {
            return price_string;
        }

        

        
    }
}
