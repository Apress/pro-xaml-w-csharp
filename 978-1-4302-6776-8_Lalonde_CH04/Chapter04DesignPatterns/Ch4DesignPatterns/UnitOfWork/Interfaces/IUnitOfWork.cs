using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch4DesignPatterns.Entity;

namespace Ch4DesignPatterns.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IEnumerable<Product> Products { get; set; }
        void Add(Product newProduct);
        Product Save(Product newProduct);
    }
}
