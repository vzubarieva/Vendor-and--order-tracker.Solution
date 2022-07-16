using Microsoft.VisualStudio.TestTools.UnitTesting;
using VAOT.Models;
using System.Collections.Generic;
using System;

namespace VAOT.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Vendor's name", "Vendor's description"); //We pass in "test" as an argument here.
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Vendor's Name";
            Vendor newVendor = new Vendor("Vendor's Name", "Vendor's description");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            Vendor newVendor = new Vendor("Vendor's Name", "Vendor's description");
            string updatedName = "Vendor's name2";
            newVendor.Name = updatedName;
            string result = newVendor.Name;
            Assert.AreEqual(updatedName, result);
        }

        [TestMethod]
        public void GetVendorDescription_ReturnsVendorDescription_String()
        {
            string vendorDescription = "Vendor's description";
            string name = "Vendor's name";
            Vendor newVendor = new Vendor(name, vendorDescription);
            string result = newVendor.VendorDescription;
            Assert.AreEqual(vendorDescription, result);
        }

        [TestMethod]
        public void SetVendorDescription_SetVendorDescription_String()
        {
            Vendor newVendor = new Vendor("Vendor's Name", "Vendor's description");
            string updatedVendorDescription = "Vendor's description2";
            newVendor.VendorDescription = updatedVendorDescription;
            string result = newVendor.VendorDescription;
            Assert.AreEqual(updatedVendorDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_VendorList()
        {
            List<Vendor> newList = new List<Vendor> { };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsVendors_VendorList()
        {
            Vendor newVendor1 = new Vendor("Vendor's Name1", "Vendor's description");
            Vendor newVendor2 = new Vendor("Vendor's Name2", "Vendor's description");
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            string name = "Vendor's Name";
            string vendorDescription = "Vendor's description";
            Vendor newVendor = new Vendor(name, vendorDescription);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }





    }
}
