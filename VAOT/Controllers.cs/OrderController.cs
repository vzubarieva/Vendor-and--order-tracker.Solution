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

        [HttpGet("/vendor/{Id}/order/new")]
        public ActionResult New(int searchId)
        {
            Vendor currentVendor = Vendor.Find(searchId);
            return View(currentVendor);
        }

        [HttpGet("/vendor/{vendorId}/order/{orderId}")]
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
