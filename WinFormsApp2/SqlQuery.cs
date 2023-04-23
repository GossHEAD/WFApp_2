using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Data.Sqlite;

namespace WinFormsApp2
{
    public class SqlQuery
    {
        internal static List<Product> ConnectionToSQLAndShowUsers()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"
                        select ID,
                        Name, Count, Category FROM Product;", connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            List<Product> products = new List<Product>();
                            while (reader.Read())
                            {
                                products.Add(new Product()
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
            catch (Exception e )
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            return null;
        }
        internal static List<Product> AddAndShowProducts(int id, string name, int count, string category)
        {
            try
            {
                string sqlexp1 = $"UPDATE sqlite_sequence SET seq = {id} WHERE name = 'Product'";
                string sqlexp = @"INSERT INTO Product(Name, Count, Category) VALUES(@name, @count, @category)";
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();
                    var cmd1 = new SQLiteCommand(sqlexp1, connection);
                    var cmd = new SQLiteCommand(sqlexp, connection);

                    SQLiteParameter Name = new SQLiteParameter("@name", name);
                    cmd.Parameters.Add(Name);
                    SQLiteParameter Count = new SQLiteParameter("@count", count);
                    cmd.Parameters.Add(Count);
                    SQLiteParameter Category = new SQLiteParameter("@category", category);
                    cmd.Parameters.Add(Category);
                    cmd1.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from Product";
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
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            return null;
        }
        internal static List<Product> UpdateAndShowUsers(int id, string name, int count, string category)
        {
            try
            {
                string sqlexp = $@"UPDATE Product
                                set Name = @name,
	                            Count = @count,
	                            Category = @category,	                    
                                where ID = @id";
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();

                    var cmd = new SQLiteCommand(sqlexp, connection);

                    SQLiteParameter Name = new SQLiteParameter("@name", name);
                    cmd.Parameters.Add(Name);
                    SQLiteParameter Count = new SQLiteParameter("@count", count);
                    cmd.Parameters.Add(Count);
                    SQLiteParameter Category = new SQLiteParameter("@category", category);
                    cmd.Parameters.Add(Category);
                    SQLiteParameter ProductId = new SQLiteParameter("@id", id);
                    cmd.Parameters.Add(ProductId);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from Product";
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
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            return null;
        }
        internal static List<Product> DeleteAndShowUsers(int id)
        {
            try
            {
                string sqlexp = $@"DELETE FROM Product WHERE ID = {id}";
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand(sqlexp, connection);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * from Product";
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Product> users = new List<Product>();
                        while (reader.Read())
                        {
                            users.Add(new Product
                            {
                                ProductId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Count = reader.GetInt32(2),
                                Category = reader.GetString(3),
                            });
                        }
                        return users;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            return null;
        }
        internal static List<Product> TruncateAllUsers()
        {
            try
            {
                string sqlexp = $@"DELETE FROM Product";
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand(sqlexp, connection);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select * from Product";
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Product> products = new List<Product>();
                        return products;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
                
            }
            return null;
        }
        internal static List<Product> TakeFromFileAndShowUsers(string name, int count, string category)
        {
            try
            {
                string sqlexp1 = "UPDATE sqlite_sequence SET seq=0 WHERE name = 'Product'";

                string sqlexp = @"insert into Product(
                        Name,
                        Count, Category)
                        values(@name, @count, @category)";
                using (var connection = new SQLiteConnection(@"Data Source = product.db"))
                {
                    connection.Open();
                    var cm1 = new SQLiteCommand(sqlexp1, connection);
                    var cmd = new SQLiteCommand(sqlexp, connection);

                    SQLiteParameter Name = new SQLiteParameter("@name", name);
                    cmd.Parameters.Add(Name);
                    SQLiteParameter Count = new SQLiteParameter("@count", count);
                    cmd.Parameters.Add(Count);
                    SQLiteParameter Category = new SQLiteParameter("@сategory", category);
                    cmd.Parameters.Add(Category);
                    cm1.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from Product";
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
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            return null;
        }
    }
}
    

