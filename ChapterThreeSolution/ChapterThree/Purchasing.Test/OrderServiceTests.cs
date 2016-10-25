using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Purchasing.Domain;
using Purchasing.Domain.Service;
using Purchasing.Domain.Service.Interfaces;

namespace Purchasing.Test
{
    [TestClass]
    public class OrderServiceTests
    {
        private IOrderRepository _OrderRepository;
        private IOrderService _OrderService;
        private IUnitOfWork _UnitOfWork;

        [TestInitialize]
        public void Init_Tests()
        {
            _UnitOfWork = new UnitOfWork();
            _OrderRepository = new OrderRepository(_UnitOfWork);
            _OrderService = new OrderService(_OrderRepository);
        }

        [TestMethod]
        public void When_An_Order_Is_Passed_To_The_OrderService_Then_An_Invoice_Is_Returned()
        {
            var order = new Order();

            order.AddLineItem(new LineItem { Id = 0, Price = 20.00 });
            order.AddLineItem(new LineItem { Id = 1, Price = 20.00 });
            
            var invoice = _OrderService.CreateInvoice(order);

            Assert.IsNotNull(invoice);
        }
    }
}
