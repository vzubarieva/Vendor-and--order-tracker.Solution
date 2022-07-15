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
            Vendor newVendor = new Vendor(); //We pass in "test" as an argument here.
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        //
        //[TestMethod]
        //public void GetDescription_ReturnsDescription_String()
        //{
        //  //Arrange
        //  string description = "Walk the dog.";
        //  Item newItem = new Item(description);
        //
        //  //Act
        //  string result = newItem.Description;
        //
        //  //Assert
        //  Assert.AreEqual(description, result);
        //}





    }
}
