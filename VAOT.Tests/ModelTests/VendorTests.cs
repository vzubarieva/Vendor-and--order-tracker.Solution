using Microsoft.VisualStudio.TestTools.UnitTesting;
using VAOT.Models;
using System.Collections.Generic;
using System;

namespace VAOT.Tests
{
    [TestClass]
    public class VendorTests //: IDisposable
    {
        //public void Dispose()
        //{
        //  Item.ClearAll();
        //}

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Vendor's name"); //We pass in "test" as an argument here.
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Vendor's Name";
            Vendor newVendor = new Vendor(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            string name = "Vendor's name";
            Vendor newVendor = new Vendor(name);
            string updatedName = "Vendor's name2";
            newVendor.Name = updatedName;
            string result = newVendor.Name;
            Assert.AreEqual(updatedName, result);
        }





    }
}
