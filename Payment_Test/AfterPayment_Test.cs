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
            string actualReturnValue = afPhysical.TakeActionAfterPayment("Physical");
            Assert.AreEqual(physical, actualReturnValue);
        }
            
    }

}
