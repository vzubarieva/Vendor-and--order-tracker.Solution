using Microsoft.VisualStudio.TestTools.UnitTesting;
using VAOT.Models;
using System.Collections.Generic;
using System;

namespace VAOT.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnsTitle_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string result = newOrder.Title;
            Assert.AreEqual("Order's title", result);
        }

        [TestMethod]
        public void SetTitle_SetTitle_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string updatedTitle = "Order's Title updated";
            newOrder.Title = updatedTitle;
            string result = newOrder.Title;
            Assert.AreEqual(updatedTitle, result);
        }

        [TestMethod]
        public void GetOrderDescription_ReturnsOrderDescription_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string result = newOrder.OrderDescription;
            Assert.AreEqual("Order's description", result);
        }

        [TestMethod]
        public void SetOrderDescription_SetOrderDescription_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string updatedOrderDescription = "Order's description updated";
            newOrder.OrderDescription = updatedOrderDescription;
            string result = newOrder.OrderDescription;
            Assert.AreEqual(updatedOrderDescription, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Double()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            Assert.AreEqual(28.00, newOrder.Price);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string result = newOrder.Date;
            Assert.AreEqual("2022-10-26", newOrder.Date);
        }

        [TestMethod]
        public void SetDate_SetDate_String()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            string updatedDate = "2022-11-26";
            newOrder.Date = updatedDate;
            string result = newOrder.Date;
            Assert.AreEqual(updatedDate, result);
        }

        [TestMethod]
        public void GetId_ReturnId_Int()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            int result = newOrder.Id;
            Assert.AreEqual(1, newOrder.Id);
        }

        [TestMethod]
        public void GetAll_ReturnsAllOrders_OrdersList()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            Order newOrder2 = new Order(
                "Order's title2",
                "Order's description2",
                35.00,
                "2022-10-28"
            );
            List<Order> allOrders = new List<Order> { newOrder, newOrder2 };
            CollectionAssert.AreEqual(allOrders, Order.GetAll());
        }

        [TestMethod]
        public void Find_ReturnsSpecificOrder_Order()
        {
            Order newOrder = new Order("Order's title", "Order's description", 28.00, "2022-10-26");
            Order newOrder2 = new Order(
                "Order's title2",
                "Order's description2",
                35.00,
                "2022-10-28"
            );
            Assert.AreEqual(newOrder, Order.Find(1));
        }
    }
}
