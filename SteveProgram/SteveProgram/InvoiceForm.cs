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

        PrintingClass testDocument1 = new PrintingClass(" Hello I am from the future bro\nWe print stuff in the future!");

        public ArrayList table_quantities = new ArrayList();
        public ArrayList table_descriptions = new ArrayList();
        public ArrayList table_added_quant = new ArrayList();
        public ArrayList table_total_weight = new ArrayList();
        public ArrayList table_unit_prices = new ArrayList();
        public ArrayList table_total_cost = new ArrayList();
        public ArrayList table_added_content = new ArrayList();

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
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreview.Document = testDocument1;
                testDocument1.Print();
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
                productNames.Add(p.getName());
            }
        }

        private void addToFormButton_Click(object sender, EventArgs e)
        {
            TextBox q = new TextBox();
            q.Text = "10";
            table_quantities.Add(q);
            q.TextChanged += new System.EventHandler(this.quan_changed);
            q.Tag = rows;
            rows++;

            Label d = new Label();
            d.Text = comboBox1.SelectedItem.ToString();
            d.AutoSize = true;
            table_descriptions.Add(d);

            Label a = new Label();
            a.Text = "5";
            table_added_quant.Add(a);

            Label w = new Label();
            w.Text = "15";
            table_total_weight.Add(w);

            Label p = new Label();
            p.Text = "3.99";
            table_unit_prices.Add(p);

            Label t = new Label();
            t.Text = "59.85";
            table_total_cost.Add(t);

            Label c = new Label();
            c.Text = "10# Venison 5# Pork";
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

        }

        private void quan_changed(object sender, EventArgs e)
        {
            MessageBox.Show(((TextBox)sender).Text + ", " + ((TextBox)sender).Tag);
        }


    }
}
