using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Purchasing.Domain;

namespace Purchasing.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private IList<Order> _Orders;

        public UnitOfWork()
        {
            _Orders = new List<Order>();
        }

        public void SaveChanges()
        {
            _Orders.Clear();
        }
    }
}
