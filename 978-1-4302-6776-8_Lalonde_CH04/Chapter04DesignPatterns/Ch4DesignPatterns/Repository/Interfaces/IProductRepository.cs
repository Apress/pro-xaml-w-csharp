using System;
using System.Collections.Generic;
using Ch4DesignPatterns.Entity;

namespace Ch4DesignPatterns.Repository.Interfaces
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        Product NewProduct(bool createInDatabase);
        Product SaveProduct(Product product);
    }
}
