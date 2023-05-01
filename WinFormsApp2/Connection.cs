using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp2;

public class Connection
{
    internal static List<Product> ConnectionToSQLAndShowProducts()
    {
        try
        {
            using (var connection = new SQLiteConnection(@"Data Source = product.db"))
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(@"select ID,
	                                                Name,
	                                                Count,
	                                                Category
                                                    FROM Product;", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Product> products = new List<Product>();
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductId = reader.GetInt32(0),
                                Name = reader.GetString(1),

                                Count = reader.GetInt32(2),
                                Category = reader.GetString(3),
                            });
                        }
                        return products;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return null;
    }
}
