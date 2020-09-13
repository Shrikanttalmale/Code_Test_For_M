using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payment;

namespace Payment_Test
{
    [TestClass]
    public class AfterPayment_Test
    {
        [TestMethod]
        public void ActionsAfterPayment()
        {
            var action = new AfterPayment();
            bool isSuccess = action.TakeAction();
            Assert.IsTrue(isSuccess);
        }


        [TestMethod]
        public void AfterPaymentForPhysicalProducts_Test()
        {
            string physical = "Physical";
            var afPhysical = new AfterPayment.PhysicalProduct();
            var actualReturnValue = afPhysical.TakeActionAfterPayment();
            Assert.AreEqual(physical, actualReturnValue);
        }

        [TestMethod]
        public void AfterPaymentForBook_Test()
        {
            string book = "Book";
            var aBook = new AfterPayment.Books();
            string actualReturnValue = aBook.TakeActionAfterPayment();
            Assert.AreEqual(book, actualReturnValue);
        }

        [TestMethod]
        public void AfterPaymentForMembership_Test()
        {
            string membership = "Activate Membership";
            var aMembership= new AfterPayment.Membership();
            string actualReturnValue = aMembership.TakeActionAfterPayment();
            Assert.AreEqual(membership, actualReturnValue);
        }

    }

}
