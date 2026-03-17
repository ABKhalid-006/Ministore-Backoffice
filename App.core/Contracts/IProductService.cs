using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.core.Contracts
{
  public interface IProductService
    {
        public Product Add(Product product);
        public bool Update(Product product);
        public bool Delete(string id);
        public Product GetById(string id);
        public List<Product> GetAll();
        public List<Product> Search (string text, ProductCategoryEnum? category, ProductStatusEnum? status);

    }
}
