using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nicolas_Tambellini_CPRG214_Lab_3.Models
{
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>(); // list of products

            //Sql connection block to connect to HalloweenDB; closes connection at end of block
            //Executes query to retrieve ProductId's
            using (SqlConnection connection = GetDBConnection())
            {
                string query = "SELECT * " +
                                "FROM Products " +
                                "ORDER BY ProductId";

                //sql command block; disposes command at end of block
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Open connection
                    connection.Open();
                    SqlDataReader reader =
                        cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // reads product properties from DB
                    while (reader.Read())
                    {
                        Product newProduct = new Product();
                        newProduct.ProductID = reader["ProductID"].ToString();
                        newProduct.Name = reader["Name"].ToString();
                        newProduct.ShortDescription = reader["ShortDescription"].ToString();
                        newProduct.LongDescription = reader["LongDescription"].ToString();
                        newProduct.CategoryID = reader["CategoryID"].ToString();
                        newProduct.ImageFile = reader["ImageFile"].ToString();
                        newProduct.UnitPrice = (decimal)reader["UnitPrice"];
                        newProduct.OnHand = (int)reader["OnHand"];

                        // Adds products to the product list
                        products.Add(newProduct);

                    }

                }

                // return the entire list of products
                return products;

            }
        }

        /// <summary>
        /// Gets Connection to the database
        /// </summary>
        /// <returns>connection string and connection</returns>
        public static SqlConnection GetDBConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["HalloweenDBConnection"].ConnectionString);
        }
    }
}