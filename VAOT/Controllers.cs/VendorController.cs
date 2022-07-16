using Microsoft.AspNetCore.Mvc;
using VAOT.Models;
using System.Collections.Generic;

namespace VAOT.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string vendorDescription)
        {
            Vendor myVendor = new Vendor(name, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpPost("/vendors/delete")]
        public ActionResult DeleteAll()
        {
            Vendor.ClearAll();
            return View();
        }
    }
}
