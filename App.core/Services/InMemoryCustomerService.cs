using System;
using System.Collections.Generic;
using System.Text;
using App.core.Contracts;
using App.core.Models;
namespace App.core.Services
{
    internal class InMemoryCustomerService: ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();

        List<Customer> GetAll()
        {
            return _customers.ToList();
        }
        Customer GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);

        }
        void Add(Customer customer)
        {
            if(customer == null)
                throw new ArgumentNullException("Customer cannot be null");
            _customers.Add(customer);
        }
        void Update(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException("customer cannot be null");

            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing == null) throw new Exception($"Customer with {customer.Id} not found");

            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            existing.Address = customer.Address;

        }
        void Delete(string id)
        {
            _customers.RemoveAll(c => c.Id == id);

        }

        List<Customer> Search(string query)
        {
            if(string.IsNullOrWhiteSpace(query))
                return GetAll();

            return _customers.Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();


        }


    }
}
