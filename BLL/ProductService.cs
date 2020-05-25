using BLL.interfaces;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProductService : IProductService
    {
        IProductRepository repository;

        public ProductService(IProductRepository _repository)
        {
            repository = _repository;
        }

        public List<Product> GetAllProducts()
        {
            return repository.Get();
        }

        public void Add(Product product)
        {
            repository.Add(product);
        }

        public Product FindById(int id)
        {
            return repository.FindById(id);
        }

        public void Update(Product product)
        {
            repository.Update(product);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
