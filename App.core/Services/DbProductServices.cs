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
            throw new NotImplementedException();
        }

        bool IProductService.Delete(string id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Products";
                cmd.Connection = conn;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader["Id"].ToString();
                        prod.Name = reader["Name"].ToString();


                       products.Add(prod);
                    }

                }
            }
            return products;
        }

        Product IProductService.GetById(string id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            // throw new NotImplementedException();
            return null;
        }

        bool IProductService.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
