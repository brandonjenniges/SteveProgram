using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace ButcherBlock
{
    public partial class AddForm : Form
    {
        private PriceForm parentPriceForm;
     
        public AddForm(PriceForm p)
        {
            parentPriceForm = p;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source=products.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('" + productNameTextBox.Text + "', '" + productPriceTextBox.Text + "');";
            sqlite_cmd.ExecuteNonQuery();

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();

            parentPriceForm.loadPrices();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
