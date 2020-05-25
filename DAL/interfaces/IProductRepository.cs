using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IProductRepository
    {
        List<Product> Get();

        Product FindById(int id);

        void Add(Product product);

        void Update(Product product);

        void Delete(int id);
    }
}
