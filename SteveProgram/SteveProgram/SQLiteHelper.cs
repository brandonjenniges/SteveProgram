using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace ButcherBlock
{
    class SQLiteHelper
    {
        private bool db_debug = false;

        // We use these three SQLite objects:
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;

        public SQLiteHelper()
        {
            initializeProducts();
        }

        public void initializeProducts()
        {
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

            //sqlite_conn.Close();
        }

        public List<Product> getAllProducts()
        {
            sqlite_conn = new SQLiteConnection("Data Source=products.db;Version=3;New=" + db_debug + ";Compress=True;");
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM Products";

            List<Product> products = new List<Product>();

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            products.Clear();

            while (sqlite_datareader.Read()) 
            {
                products.Add(new Product(Convert.ToInt32(sqlite_datareader.GetString(0)), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2)));

            }

            sqlite_conn.Close();

            return products;
        }

        public void updateProduct()
        {
        }

        public void addProduct()
        {
        }

        public void deleteProduct()
        {
        }
    }
}
