using App.core.Contracts;
using App.core.Models;
using App.core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.core.Services
{
    public class DbProductServices : IProductService
    {
        private readonly String _connectionString;
        public DbProductServices(string connectionString) 
        {
            _connectionString = connectionString;
        }

        Product IProductService.Add(Product product)
        {
            product.Id = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Product (Id, Name, Category, Price, Stock, Status) VALUES (@Id, @Name, @Category, @Price, @Stock, @Status)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    return product;
                else
                    return null;

                
            }

        }


        bool IProductService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Product WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                int rows = cmd.ExecuteNonQuery();
                return (rows > 0);
            }
        }

        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Product";
                cmd.Connection = conn;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader["Id"].ToString();
                        prod.Name = reader["Name"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(reader["Category"].ToString(), out var cat) ? cat : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);
                        prod.Stock = Convert.ToInt32(reader["Stock"]);
                        prod.Status = Enum.TryParse<ProductStatusEnum>(reader["Status"].ToString(), out var statusEnum) ? statusEnum : ProductStatusEnum.Active;
                        



                        products.Add(prod);
                    }

                }
            }
            return products;
        }

        Product IProductService.GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            Category = Enum.TryParse<ProductCategoryEnum>(reader["Category"].ToString(), out var cat) ? cat : ProductCategoryEnum.None,
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            Status = Enum.TryParse<ProductStatusEnum>(reader["Status"].ToString(), out var statusEnum) ? statusEnum : ProductStatusEnum.Active
                        };
                    }
                }
            }
            return null;
        }

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Product WHERE Name LIKE @name";

                if(category != null)
                {
                    sql = sql + " AND Category = @category";

                }
                if (status != null)
                {
                        sql = sql + " AND Status = @status";

                
                }
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@name", "%" + text.Trim() + "%");
                if (category != null)
                {
                    cmd.Parameters.AddWithValue("@category", category.ToString());
                }
                if (status != null)
                {
                    cmd.Parameters.AddWithValue("@status", status.ToString());
                }

                using (SqlDataReader reader = cmd.ExecuteReader() )
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader["Id"].ToString();
                        prod.Name = reader["Name"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(reader["Category"].ToString(), out var cat) ? cat : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);
                        prod.Stock = Convert.ToInt32(reader["Stock"]);
                        prod.Status = Enum.TryParse<ProductStatusEnum>(reader["Status"].ToString(), out var statusEnum) ? statusEnum : ProductStatusEnum.Active;




                        products.Add(prod);
                    }
                }
               
                
            }
            return products;

        }

        bool IProductService.Update(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Product SET Name = @Name, Category = @Category, Price = @Price, Stock = @Stock, Status = @Status WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0);
            }
        }
    }
}
