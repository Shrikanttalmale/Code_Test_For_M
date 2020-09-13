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
            AfterPayment afPhysical = new AfterPayment();
            string actualReturnValue = afPhysical.TakeActionAfterPaymentForPhyscialProd(physical);
            Assert.AreEqual(physical, actualReturnValue);
        }

        [TestMethod]
        public void AfterPaymentForBook_Test()
        {
            string book = "Book";
            AfterPayment afPhysical = new AfterPayment();
            string actualReturnValue = afPhysical.TakeActionAfterPaymentForBood(book);
            Assert.AreEqual(book, actualReturnValue);
        }

        [TestMethod]
        public void AfterPaymentForMembership_Test()
        {
            string membership = "Member";
            AfterPayment afPhysical = new AfterPayment();
            string actualReturnValue = afPhysical.TakeActionAfterPaymentForMembership(membership);
            Assert.AreEqual(membership, actualReturnValue);
        }

    }

}
