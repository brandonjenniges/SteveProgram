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

namespace ButcherBlock
{
    public partial class winForm : Form
    {

        PrintingClass testDocument1 = new PrintingClass(" Hello I am from the future bro\nWe print stuff in the future!");

        public winForm()
        {
            InitializeComponent();
            //ReadFromFile();
        }

        private void ReadFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"test.txt");
            foreach (string line in lines)
            {
            }
        }

        private void reloadPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReadFromFile();
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
            new PriceForm().Show();
        }
    }
}
