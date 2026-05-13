using System;
using System.Collections.Generic;
using System.Text;
using App.core.Models;
namespace App.core.Contracts
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(string id);
        Customer Add (Customer customer);
        Customer Update (Customer customer);
        Customer Delete (string id);

        List<Customer> Search(string query);

    }
}
