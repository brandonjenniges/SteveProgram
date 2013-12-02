using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherBlock
{
    class FormulaHandler
    {
        private double toAdd;
        private string contents;

        public FormulaHandler(int product_id, double quantity)
        {
            switch (product_id)
            {
                case 0:
                    toAdd = 0;
                    contents = "Processing + hide";
                    break;
                case 1:
                    toAdd = 0;
                    contents = "";
                    break;
                case 2:
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case 3:
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case 4:
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case 5:
                    toAdd = 0;
                    contents = quantity + "# Green Weight";
                    break;
                case 6:
                    toAdd = Math.Floor(quantity / 10);
                    contents = toAdd > 0 ? quantity + "# Venison " + toAdd + "# Beef Trim" : quantity + "# Venison ";
                    break;
                case 7:
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case 8:
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case 9:
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork Trim";
                    break;
                case 10:
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case 11:
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case 12:
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case 13 :
                    toAdd = 0;
                    contents = quantity + "# Green Weight";
                    break;
                case 14:
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd /2 + "# Bacon " +toAdd/2 + "# Beef";
                    break;
                case 15:
                    toAdd = quantity;
                    contents = quantity + "# Venison " + toAdd + "# Pork Trim";
                    break;
                default:
                    toAdd = 0;
                    contents = "Error";
                    break;
            }
        }

        public double getToAdd()
        {
            return toAdd;
        }

        public string getContents()
        {
            return contents;
        }
    }
}
