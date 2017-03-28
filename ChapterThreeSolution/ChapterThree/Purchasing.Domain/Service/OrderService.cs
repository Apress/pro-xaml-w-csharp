using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Purchasing.Domain.Service.Interfaces;

namespace Purchasing.Domain.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _OrderRepository = orderRepository;
        }

        public Invoice CreateInvoice(Order order)
        {
            _OrderRepository.AddOrder(order);
            _OrderRepository.Commit();

            var invoice = 
                new Invoice { OrderTotal = order.CalculateOrderTotal() };

            return invoice;
        }
    }
}
