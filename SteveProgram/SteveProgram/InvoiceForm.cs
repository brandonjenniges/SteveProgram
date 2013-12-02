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
        public ArrayList table_delete_buttons = new ArrayList();

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
            this.WindowState = FormWindowState.Maximized;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            Label deleteHeading = new Label();
            deleteHeading.Text = "Delete";

            tableLayoutPanel1.Controls.Add(quantityHeading, 0, 0);

            tableLayoutPanel1.Controls.Add(descriptionHeading, 1, 0);

            tableLayoutPanel1.Controls.Add(addedWeight, 2, 0);

            tableLayoutPanel1.Controls.Add(totalWeight, 3, 0);

            tableLayoutPanel1.Controls.Add(priceHeading, 4, 0);

            tableLayoutPanel1.Controls.Add(amountHeading, 5, 0);

            tableLayoutPanel1.Controls.Add(addedHeading, 6, 0);

            tableLayoutPanel1.Controls.Add(deleteHeading, 7, 0);
 
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

            tableLayoutPanel1.RowCount++;

            addToFormButton.Enabled = false;

            Product newProduct = new Product();
            newProduct.Id = comboBox1.SelectedIndex;
            newProduct.Name = comboBox1.SelectedItem.ToString();
            newProduct.Quantity = newProduct.Name == "Deer Processing" ? 1 : 10;

            FormulaHandler f = new FormulaHandler(newProduct.Id, newProduct.Quantity);

            newProduct.AddedWeight = f.getToAdd();
            newProduct.ProductContents = f.getContents();

            foreach (Product pa in products)
            {
                if (pa.Name == newProduct.Name)
                {
                    newProduct.Price = pa.Price;
                    break;
                }
            }

            TextBox q = new TextBox();
            q.Text = newProduct.Quantity.ToString();
            table_quantities.Add(q);
            q.TextChanged += new System.EventHandler(this.quan_changed);
            q.Tag = order.Count + 1;
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

            Button del = new Button();
            del.Text = "Delete";
            del.Tag = order.Count + 1;
            del.AutoSize = true;
            del.Click += new System.EventHandler(this.deleteOrderItem);
            table_delete_buttons.Add(del);

            int row = order.Count;

            tableLayoutPanel1.Controls.Add((TextBox)table_quantities[row], 0, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_descriptions[row], 1, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_added_quant[row], 2, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_total_weight[row], 3, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_unit_prices[row], 4, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_total_cost[row], 5, row + 1);

            tableLayoutPanel1.Controls.Add((Label)table_added_content[row], 6, row + 1);

            tableLayoutPanel1.Controls.Add((Button)table_delete_buttons[row], 7, row + 1);
               
            tableLayoutPanel1.Refresh();

            order.Add(newProduct);

            addToFormButton.Enabled = true;
            
        }

        private void quan_changed(object sender, EventArgs e)
        {
            try
            {
                int inputValue = Convert.ToInt32(((TextBox)sender).Text);
                int id = Convert.ToInt32(((TextBox)sender).Tag) - 1;

                FormulaHandler f = new FormulaHandler(order[id].Id, inputValue);

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
                MessageBox.Show(ex.ToString());
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
                        lines.Add("Cost: " + p.TotalWeight + " x " + p.PriceString);
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
            float linesPerPage = 0;
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

        private void deleteOrderItem(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(((Button)sender).Tag) - 1;

            order.RemoveAt(row);
            tableLayoutPanel1.Invalidate();

            tableLayoutPanel1.Refresh();

            for (int i = 0; i < 8; i++)
            {
                tableLayoutPanel1.Controls.RemoveAt((row + 1 ) * 8);
            }

            table_quantities.RemoveAt(row);
            table_descriptions.RemoveAt(row);
            table_added_quant.RemoveAt(row);
            table_total_weight.RemoveAt(row);
            table_unit_prices.RemoveAt(row);
            table_total_cost.RemoveAt(row);
            table_added_content.RemoveAt(row);
            table_delete_buttons.RemoveAt(row);

            for (int i = 1; i <= table_delete_buttons.Count; i++)
            {
                ((Button)table_delete_buttons[i - 1]).Tag = i;
                ((TextBox)table_quantities[i - 1]).Tag = i;
            }

            for (int i = 0; i < order.Count; i++)
            {
                tableLayoutPanel1.Controls.Add((TextBox)table_quantities[i], 0, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_descriptions[i], 1, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_added_quant[i], 2, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_total_weight[i], 3, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_unit_prices[i], 4, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_total_cost[i], 5, i + 1);

                tableLayoutPanel1.Controls.Add((Label)table_added_content[i], 6, i + 1);

                tableLayoutPanel1.Controls.Add((Button)table_delete_buttons[i], 7, i + 1);
            }

            tableLayoutPanel1.RowCount -= 1;
        }


    }
}
