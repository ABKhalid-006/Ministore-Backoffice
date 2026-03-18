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
            if(product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);
            }
            return product;
        }
        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? Existing = _products.Find(p => p.Id == product.Id);
                if (Existing == null) return false;

                Existing.Name = product.Name;
                Existing.Category = product.Category;
                Existing.Price = product.Price;
                Existing.Status = product.Status;
                Existing.Stock = product.Stock;

                return true;

            }
            return false;
        }
        public bool Delete(string id)
        {
            Product prodToBeDeleted = GetById(id);
            _products.Remove(prodToBeDeleted);
            return true;
        }
        public Product? GetById(string id)
        {
            Product? prod = _products.Find(p => p.Id == id);
            return prod;
        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            //LINQ
            List<Product> _filtered = _products.ToList();
            _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();

            if (category is not null)
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }

            if (status is not null)
            {
                _filtered = _filtered.Where(p => p.Status == status).ToList();
            }

            return _filtered;

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
