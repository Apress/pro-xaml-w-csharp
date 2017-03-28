using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Purchasing.Domain.Service;

namespace Purchasing.Domain
{
    public class OrderRepository : IOrderRepository
    {
        private IList<Order> _Orders;
        private IUnitOfWork _UnitOfWork;

        public OrderRepository(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            _Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            _Orders.Add(order);
        }

        public Order RetreieveOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderById(int id)
        {
            throw new NotImplementedException();
        }


        public void Commit()
        {
            _UnitOfWork.SaveChanges();
        }
    }
}
