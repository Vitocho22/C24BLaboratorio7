using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductData
    {


        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=master;User ID=DB_Sinche;Password=admin123;";

        public List<Product> Get()
            {
                List<Product> products = new List<Product>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("USP_ListProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();
                        
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.ProductID = Convert.ToInt32(reader["Product_id"]);
                                product.Name = reader["Name"].ToString();
                                product.Price = Convert.ToDecimal(reader["Price"]);
                                product.Stock = Convert.ToInt32(reader["Stock"]);
                                products.Add(product);
                            }
                            reader.Close();
                        
                        return products;
                    }
                }
            }
        
        public void Insert()
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {
        }
    }
}
