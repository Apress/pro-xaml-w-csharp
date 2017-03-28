using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Purchasing.Domain;

namespace Purchasing.Test
{
    [TestClass]
    public class OrderTests
    {
        

        [TestMethod]
        public void When_An_Order_Has_No_LineItems_Then_CalcuateOrderTotal_Returns_Zero()
        {
            var order = new Order();

            var expectedTotal = 0.0;
            var actualTotal = order.CalculateOrderTotal();

            Assert.AreEqual(expectedTotal, actualTotal, "The total should be zero.");
        }

        [TestMethod]
        public void When_An_Order_Has_LineItems_Then_CalcuateOrderTotal_Returns_The_Total_Of_The_Prices()
        {
            var order = new Order();
            order.AddLineItem(new LineItem { Id = 0, Price = 50.25 });
            order.AddLineItem(new LineItem { Id = 1, Price = 50.25 });

            var expectedTotal = 100.50;
            var actualTotal = order.CalculateOrderTotal();

            Assert.AreEqual(expectedTotal, actualTotal, "The total should be $100.50.");
        }

        [TestMethod]
        public void When_A_Order_Has_No_LineItems_Then_LineItemCount_Returns_Zero()
        {
            var order = new Order();

            var expectedCount = 0;
            var actualCount = order.LineItemCount;

            Assert.AreEqual(expectedCount, actualCount, "The count should be zero.");
        }

        [TestMethod]
        public void When_A_LineItem_Is_Added_To_An_Order_Then_LineItemCount_Returns_One()
        {
            var order = new Order();

            order.AddLineItem(new LineItem {Id = 0, Price = 20.99});

            var expectedCount = 1;
            var actualCount = order.LineItemCount;

            Assert.AreEqual(expectedCount, actualCount, "The count should be one.");
        }

        [TestMethod]
        public void When_A_LineItem_Is_Removed_From_An_Order_With_No_LineItems_Then_An_ApplicationException_Is_Thrown()
        {
            var order = new Order();

            order.AddLineItem(new LineItem { Id = 0, Price = 20.99 });

            var expectedCount = 1;
            var actualCount = order.LineItemCount;

            Assert.AreEqual(expectedCount, actualCount, "The count should be one.");
        }
    }
}
