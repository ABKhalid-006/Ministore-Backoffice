using App.core.Contracts;
using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.core.Services
{
    public class InMemoryProductService : IProductService
    {

        private List<Product> _products;

        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }


        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product product)
        {
            return false;
        }
        public bool Delete(string id)
        {
            return false;
        }
        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();

        }

        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "laptop", 
                Category = ProductCategoryEnum.Electronics,
                Price = 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Pc",
                Category = ProductCategoryEnum.Electronics,
                Price = 15000.00m,
                Stock = 15,
                Status = ProductStatusEnum.Active
            });



            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "USB",
                Category = ProductCategoryEnum.Electronics,
                Price = 150.00m,
                Stock = 100,
                Status = ProductStatusEnum.Active
            });



        }

        private string GenerateId()
        {
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}
