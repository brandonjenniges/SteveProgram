using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Finisar.SQLite;
using System.Collections;

namespace ButcherBlock
{
    public partial class InvoiceForm : Form
    {

        List<string> lines = new List<string>();
        int lineNumber = 0;

        PrintingClass test = new PrintingClass();
        public ArrayList table_quantities = new ArrayList();
        public ArrayList table_descriptions = new ArrayList();
        public ArrayList table_added_quant = new ArrayList();
        public ArrayList table_total_weight = new ArrayList();
        public ArrayList table_unit_prices = new ArrayList();
        public ArrayList table_total_cost = new ArrayList();
        public ArrayList table_added_content = new ArrayList();

        List<Product> order = new List<Product>();
        List<Product> products = new List<Product>();
        ArrayList productNames = new ArrayList();

        SQLiteHelper helper = new SQLiteHelper();

        private int rows = 0;

        public InvoiceForm()
        {
            InitializeComponent();
            products = helper.getAllProducts();
            createProductComboList();
            createTableLayout();
        }

        private void reloadPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                preparePrint();
                printPreview.Document = test;
                test.Print();
            }*/

            PrintDialog printDlg = new PrintDialog();

            PrintDocument printDoc = new PrintDocument();

            printDoc.DocumentName = "Print Document";

            printDoc.PrintPage += new PrintPageEventHandler
                   (this.pd_PrintPage);

            printDlg.Document = printDoc;

            printDlg.AllowSelection = true;

            printDlg.AllowSomePages = true;

            //Call ShowDialog

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                preparePrint();
                printDoc.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void priceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PriceForm(this).Show();
        }

        private void createTableLayout()
        {

            // Table Headings
            Label quantityHeading = new Label();
            quantityHeading.Text = "Quan";

            Label descriptionHeading = new Label();
            descriptionHeading.Text = "Description";

            Label addedWeight = new Label();
            addedWeight.Text = "Added";

            Label totalWeight = new Label();
            totalWeight.Text = "Weight";

            Label priceHeading = new Label();
            priceHeading.Text = "Price";

            Label amountHeading = new Label();
            amountHeading.Text = "Amount";

            Label addedHeading = new Label();
            addedHeading.Text = "Included";

            tableLayoutPanel1.Controls.Add(quantityHeading, 0, 0);

            tableLayoutPanel1.Controls.Add(descriptionHeading, 1, 0);

            tableLayoutPanel1.Controls.Add(addedWeight, 2, 0);

            tableLayoutPanel1.Controls.Add(totalWeight, 3, 0);

            tableLayoutPanel1.Controls.Add(priceHeading, 4, 0);

            tableLayoutPanel1.Controls.Add(amountHeading, 5, 0);

            tableLayoutPanel1.Controls.Add(addedHeading, 6, 0);
 
            comboBox1.DataSource = productNames;

          

        }

        public void createProductComboList()
        {
            foreach (Product p in products)
            {
                productNames.Add(p.Name);
            }
        }

        private void addToFormButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Id = comboBox1.SelectedIndex;
            newProduct.Name = comboBox1.SelectedItem.ToString();
            newProduct.Quantity = newProduct.Name == "Deer Processing" ? 1 : 10;

            FormulaHandler f = new FormulaHandler(newProduct.Name, newProduct.Quantity);

            newProduct.AddedWeight = f.getToAdd();
            newProduct.ProductContents = f.getContents();

            foreach (Product pa in products)
            {
                if (pa.Name == newProduct.Name)
                {
                    newProduct.Price = pa.Price;
                }
            }

            TextBox q = new TextBox();
            q.Text = newProduct.Quantity.ToString();
            table_quantities.Add(q);
            q.TextChanged += new System.EventHandler(this.quan_changed);
            q.Tag = rows;
            rows++;

            Label d = new Label();
            d.Text = newProduct.Name;
            d.AutoSize = true;
            table_descriptions.Add(d);

            Label a = new Label();
            a.Text = newProduct.AddedWeight.ToString();
            table_added_quant.Add(a);

            Label w = new Label();
            w.Text = newProduct.TotalWeight.ToString();
            table_total_weight.Add(w);

            Label p = new Label();
            p.Text = newProduct.PriceString;
            table_unit_prices.Add(p);

            Label t = new Label();
            t.Text = newProduct.TotalCostString;
            table_total_cost.Add(t);

            Label c = new Label();
            c.Text = f.getContents();
            c.AutoSize = true;
            table_added_content.Add(c);

            for (int i = 0; i < table_total_cost.Count; i++)
            {
                tableLayoutPanel1.Controls.Add((TextBox)table_quantities[i], 0, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_descriptions[i], 1, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_added_quant[i], 2, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_total_weight[i], 3, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_unit_prices[i], 4, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_total_cost[i], 5, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_added_content[i], 6, i + 1);
            }

            order.Add(newProduct);

        }

        private void quan_changed(object sender, EventArgs e)
        {
            try
            {
                int inputValue = Convert.ToInt32(((TextBox)sender).Text);
                int id = Convert.ToInt32(((TextBox)sender).Tag);

                FormulaHandler f = new FormulaHandler(order[id].Name, inputValue);

                order[id].Quantity = inputValue;
                order[id].AddedWeight = f.getToAdd();
                order[id].ProductContents = f.getContents();

                ((Label)table_added_quant[id]).Text = order[id].AddedWeight.ToString();
                ((Label)table_total_weight[id]).Text = order[id].TotalWeight.ToString();
                ((Label)table_total_cost[id]).Text = order[id].TotalCostString;
                ((Label)table_added_content[id]).Text = order[id].ProductContents;

                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.Text = "Error in order form, only numbers can be in quan";
            }

        }

        public void preparePrint()
        {
            for (int i = 0; i < 10; i++)
                doubleSpace();

            if (customer_name_tb.Text != "")
            {
                lines.Add("Name: " + customer_name_tb.Text);
                doubleSpace();
            }
            if (date_tb.Text != "")
            {
                lines.Add("Date: " + date_tb.Text);
                doubleSpace();
            }
            if (customer_address_tb.Text != "")
            {
                lines.Add("Address: " + customer_address_tb.Text);
                doubleSpace();
            }
            if (customer_email_tb.Text != "")
            {
                lines.Add("Email: " + customer_email_tb.Text);
                doubleSpace();
            }
            if (customer_phone_tb.Text != "")
            {
               lines.Add("Phone: " + customer_phone_tb.Text);
               doubleSpace();
            }
            if (license_no_tb.Text != "")
            {
                lines.Add("License No: " + license_no_tb.Text);
                doubleSpace();
            }

            lines.Add("---------------------------------");
            doubleSpace();
            doubleSpace();

            int l = 1;

            double orderCost = 0;

            foreach (Product p in order)
            {

                if (p.Quantity > 0)
                {
                    orderCost += p.TotalCost;
                    if (p.ProductContents != "")
                    {
                        lines.Add(l + ".\t " + p.Quantity + " lb(s) " + p.Name + ", " + p.PriceString);
                        lines.Add("\t\t\t-" + p.ProductContents);
                        lines.Add("Cost: " + p.TotalWeight + " x " + p.Price);
                    }
                    else
                    {
                        lines.Add(l + ".\t " + p.Name + ", " + p.PriceString);
                    }
                    lines.Add("-" + p.TotalCostString);
                    lines.Add("---------");
                    doubleSpace();
                    l++;
                }
            }

            lines.Add("Order Cost: " + orderCost.ToString("C"));

            lines.Add(null);
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0
                ;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Times New Roman", 12);

            line = "0";
            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            float[] formatTabs = { 10.0f, 20.0f };
            format.SetTabStops(10.0f, formatTabs);

            while (count < linesPerPage && line != null)
            {
                line = lines[lineNumber];
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, format);
                count++;
                lineNumber++;
            }



            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }

        public void doubleSpace()
        {
            lines.Add(" ");
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want erase everything?", "Confirm reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                customer_name_tb.Text = "";
                customer_address_tb.Text = "";
                customer_phone_tb.Text = "";
                customer_email_tb.Text = "";
                license_no_tb.Text = "";
                date_tb.Text = "";

                lines.Clear();
                lineNumber = 0;
                table_quantities.Clear();
                table_descriptions.Clear();
                table_added_quant.Clear();
                table_total_weight.Clear();
                table_unit_prices.Clear();
                table_total_cost.Clear();
                table_added_content.Clear();
                order.Clear();
            }
        }


    }
}
