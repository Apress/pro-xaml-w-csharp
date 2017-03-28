using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch4DesignPatterns.Entity;
using Ch4DesignPatterns.UnitOfWork.Interfaces;

namespace Ch4DesignPatterns.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEnumerable<Product> Products
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public Product Save(Product newProduct)
        {
            throw new NotImplementedException();
        }
    }
}
