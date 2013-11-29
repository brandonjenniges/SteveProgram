﻿using System;
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

        public FormulaHandler(string product, double quantity)
        {
            switch (product)
            {
                case "Deer Processing":
                    toAdd = 0;
                    contents = "";
                    break;
                case "Boning":
                    toAdd = 0;
                    contents = "";
                    break;
                case "Bratwurst":
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case "Link Sausage":
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case "Bulk Breakfast Sausage":
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case "Whole Muscle Jerkey (rounds only)":
                    toAdd = 0;
                    contents = quantity + "# Green Weight";
                    break;
                case "Ground Jerky":
                    toAdd = Math.Floor(quantity / 10);
                    contents = toAdd > 0 ? quantity + "# Venison " + toAdd + "# Beef Trim" : quantity + "# Venison ";
                    break;
                case "Pepperoni Sticks":
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case "Pepperoni Sticks with cheese":
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case "Polish Sausage":
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork Trim";
                    break;
                case "Summer Sausage":
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case "Summer Sausage with cheese":
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd + "# Beef Trim";
                    break;
                case "Wieners":
                    toAdd = Math.Ceiling(quantity / 2);
                    contents = quantity + "# Venison " + toAdd + "# Pork";
                    break;
                case "Dried Venison (rounds only)" :
                    toAdd = 0;
                    contents = quantity + "# Green Weight";
                    break;
                case "Gourmet 1/3 Seasoned Venison Patties":
                    toAdd = quantity < 10 ? 1 : Math.Ceiling(quantity/5);
                    contents = quantity + "# Venison " + toAdd /2 + "# Bacon " +toAdd/2 + "# Beef";
                    break;
                case "Venison Bacon":
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
