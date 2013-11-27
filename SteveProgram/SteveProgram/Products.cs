using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherBlock
{
    class Product
    {
        private int id;
        private string name;
        private double price;
        private double quantity;
        private double added_weight;
        private string product_contents;

        public Product()
        {
        }

        public Product(int  p_id, string p_name, string p_price)
        {
            name = p_name;
            id = p_id;
           //price_string = name.Equals("Deer Processing") ? "$" + p_price : "$" + p_price + "/lb";
            price = Convert.ToDouble(p_price);
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string PriceString
        {
            get
            {
                return name.Equals("Deer Processing") ? "$" + price : "$" + price + "/lb";
            }
        }

        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double AddedWeight
        {
            get
            {
                return added_weight;
            }
            set
            {
                added_weight = value;  
            }
        }

        public double TotalWeight
        {
            get
            {
                return added_weight + quantity;
            }
        }

        public double TotalCost
        {
            get
            {
                return price * TotalWeight;
            }
        }

        public string TotalCostString
        {
            get
            {
                return "$" + TotalCost;
            }
        }

        public string ProductContents
        {
            get
            {
                return product_contents;
            }
            set
            {
                product_contents = value;
            }
        }

        

        
    }
}
