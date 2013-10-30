using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Finisar.SQLite;

namespace ButcherBlock
{
    public partial class PriceForm : Form
    {
        bool db_debug = false;
        int clickedProductId;
        string clickedProductName;
        double clickedProductPrice;

        ArrayList products = new ArrayList();

        public PriceForm()
        {
            InitializeComponent();
            loadPrices();
        }

        public void loadPrices()
        {
            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;
            

            sqlite_conn = new SQLiteConnection("Data Source=products.db;Version=3;New=" + db_debug + ";Compress=True;");
            sqlite_conn.Open();
            
            sqlite_cmd = sqlite_conn.CreateCommand();
            if (db_debug)
            {
                // Create Products table
                sqlite_cmd.CommandText = "CREATE TABLE Products (id integer primary key, name varchar(100), price text);";
                sqlite_cmd.ExecuteNonQuery();

                // Lets Insert 2013 Products into table
                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Deer Processing', '75.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Boning', '0.75');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Bratwurst', '2.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Link Sausage', '2.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Bulk Breakfast Sausage', '0.75');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Whole Muscle Jerkey " + '(' + "rounds only" + ')' + "', '3.50');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Ground Jerky', '2.50');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Pepperoni Sticks', '2.95');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Pepperoni Sticks with cheese', '3.95');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Polish Sausage', '2.75');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Summer Sausage', '2.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Summer Sausage with cheese', '3.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Wieners', '2.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Dried Vension " + '(' + "rounds only" + ')' + "', '2.00');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Gourmet 1" + '/' + "3 Seasoned Venison Patties', '2.50');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Products (name, price) VALUES ('Venison Bacon', '3.50');";
                sqlite_cmd.ExecuteNonQuery();
            }
            // But how do we read something out of our table ?
            // First lets build a SQL-Query again:
            sqlite_cmd.CommandText = "SELECT * FROM Products";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            products.Clear();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                //System.Console.WriteLine(sqlite_datareader["text"]);
                products.Add(new Product(Convert.ToInt32(sqlite_datareader.GetString(0)), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2)));

            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();

            displayProducts();
        }

        public void displayProducts()
        {
            myListView.Clear();

            //Adding columns to the ListView control
            myListView.Columns.Add("Id");
            myListView.Columns.Add("Product");
            myListView.Columns.Add("Price");

           // ListViewItem aFooItem = new ListViewItem("1");
            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem aFooItem = new ListViewItem((i+1).ToString());
                ListViewItem.ListViewSubItem aSubFooItem1 = new ListViewItem.ListViewSubItem(aFooItem, ((Product)products[i]).getName().ToString());
                ListViewItem.ListViewSubItem aSubFooItem2 = new ListViewItem.ListViewSubItem(aFooItem, ((Product)products[i]).getPriceString()); 
                aFooItem.SubItems.Add(aSubFooItem1);
                aFooItem.SubItems.Add(aSubFooItem2);
                myListView.Items.Add(aFooItem);
            }

            ResizeListViewColumns(myListView);
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private void myListView_Click(object sender, EventArgs e)
        {
            if (myListView.SelectedItems.Count > 0)
            {

                clickedProductId = ((Product)products[myListView.SelectedItems[0].Index]).getId();
                clickedProductName = ((Product)products[myListView.SelectedItems[0].Index]).getName().ToString();
                clickedProductPrice = ((Product)products[myListView.SelectedItems[0].Index]).getPriceValue();
                new EditForm(this, clickedProductId, clickedProductName, clickedProductPrice).Show();

            }   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddForm(this).Show();
        }
    }
}
