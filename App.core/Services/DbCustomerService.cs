using App.core.Contracts;
using App.core.Models;
using App.core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace App.core.Services
{
    public class DbCustomerService : ICustomerService
    {

        private readonly string _connectionString;

        public DbCustomerService(string connectionString)
        {
            _connectionString = connectionString;
        }


        Customer ICustomerService.Add(Customer customer)
        {
            customer.Id = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Customer (Id, Name, Phone, Email, Address) VALUES (@Id, @Name, @Phone, @Email, @Address)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
              
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    return customer;
                else
                    return null;


            }
        }

        Customer ICustomerService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM Customer WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    return new Customer { Id = id };
                else
                    return null;
            }
        }

        List<Customer> ICustomerService.GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer";
                cmd.Connection = conn;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer cust = new Customer();
                        cust.Id = reader["Id"].ToString();
                        cust.Name = reader["Name"].ToString();
                        cust.Phone = reader["Phone"].ToString();
                        cust.Email = reader["Email"].ToString();
                        cust.Address = reader["Address"].ToString();

                        customers.Add(cust);
                    }

                }
            }
            return customers;
        }

        Customer ICustomerService.GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        List<Customer> ICustomerService.Search(string query)
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Customer WHERE Name LIKE @name";

               
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@name", "%" + query.Trim() + "%");
                

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       Customer customer = new Customer();
                       customer.Id = reader["Id"].ToString();
                       customer.Name = reader["Name"].ToString();
                       customer.Address = reader["Address"].ToString();
                       customer.Phone = reader["Phone"].ToString();
                       customer.Email = reader["Email"].ToString();

                       customers.Add(customer);
                    }
                }


            }
            return customers;

                       
        }
               
        

        Customer ICustomerService.Update(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "UPDATE Customer SET Name = @Name, Phone = @Phone, Email = @Email, Address = @Address WHERE Id = @Id ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Address", customer.Address);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    return customer;
                else
                    return null;


            }
        }
    }
}
