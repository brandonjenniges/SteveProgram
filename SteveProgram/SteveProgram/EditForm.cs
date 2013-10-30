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
    public partial class EditForm : Form
    {
        private int productId;
        public EditForm(int id, string name, double price)
        {
            InitializeComponent();
            productId = id;
            productNameTextBox.Text = name;
            productPriceTextBox.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;


            sqlite_conn = new SQLiteConnection("Data Source=products.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "UPDATE Products SET name = '" + productNameTextBox.Text + "', price = '" + productPriceTextBox.Text + "' WHERE id = " + productId;

            sqlite_cmd.ExecuteNonQuery();

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
            
            Close();

            MessageBox.Show("Product changed");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;


            sqlite_conn = new SQLiteConnection("Data Source=products.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "DELETE FROM Products WHERE id = " + productId;

            sqlite_cmd.ExecuteNonQuery();

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();

            Close();

            MessageBox.Show("Product deleted");
        }
    }
}
