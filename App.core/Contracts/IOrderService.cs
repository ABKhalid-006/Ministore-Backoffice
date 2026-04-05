using System;
using System.Collections.Generic;
using System.Text;
using App.core.Models;
using App.core.Utilities;
namespace App.core.Contracts
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(string id);
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(string Id);

        public List<Order> GetByCustomerId(string customerId);
        public List<Order> GetByStatus(OrderStatusEnum status);

         
    }
}
