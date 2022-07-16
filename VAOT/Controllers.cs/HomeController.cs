using Microsoft.AspNetCore.Mvc;
using VAOT.Models;

namespace VAOT.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            Vendor starterVendor = new Vendor(
                "Add new vendor to Vendor List",
                "Vendor's description"
            );
            return View(starterVendor);
        }

        [Route("/vendors/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [Route("/vendors")]
        public ActionResult Create(string name, string vendorDescription)
        {
            Vendor myVendor = new Vendor("Vendor's name", "Vendor's description");
            return View("Index", myVendor);
        }


    }
}
