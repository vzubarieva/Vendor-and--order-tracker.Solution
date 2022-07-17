using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VAOT.Models;

namespace VAOT.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/order/")]
        public ActionResult Index(int vendorId)
        {
            Vendor currentVendor = Vendor.Find(vendorId);
            return View(currentVendor);
        }

        [HttpGet("/vendors/{vendorId}/order/new")]
        public ActionResult New(int vendorId)
        {
            Vendor currentVendor = Vendor.Find(vendorId);
            return View(currentVendor);
        }

        [HttpPost("/vendors/{vendorId}/order/new")]
        public ActionResult Create(
            int vendorId,
            string title,
            string orderDescription,
            double price,
            string date
        )
        {
            Vendor currentVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(title, orderDescription, price, date);
            currentVendor.AddOrder(newOrder);
            Dictionary<string, object> model = new Dictionary<string, object>
            {
                { "vendor", currentVendor },
                { "order", newOrder }
            };
            return View("Show", model);
        }

        [HttpGet("/vendors/{vendorId}/order/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>
            {
                { "vendor", vendor },
                { "order", order }
            };
            return View(model);
        }
    }
}
