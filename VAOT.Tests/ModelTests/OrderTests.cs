using Microsoft.VisualStudio.TestTools.UnitTesting;
using VAOT.Models;
using System.Collections.Generic;
using System;

namespace VAOT.Tests
{
    [TestClass]
    public class OrderTests //: IDisposable
    {
        // public void Dispose()
        //{
        //    Order.ClearAll();
        // }

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
    }
}
