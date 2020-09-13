using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Payment
{
    public abstract class ActionFactoryForPayment
    {
        public abstract ITakeAction GetAfterPaymentAction(int paymentType);
    }

   public class ActionFactory  : ActionFactoryForPayment
    {
        ITakeAction _action;

        public override ITakeAction GetAfterPaymentAction(int paymentType)
        {
            if (paymentType == 1)
            {
                _action = new AfterPayment.PhysicalProduct();
            }
            else if (paymentType == 2)
            {
                _action = new AfterPayment.Books();
            }
            else if (paymentType == 3)
            {
               _action = new AfterPayment.Membership();
            }

            return _action;
        }

       
    }
}
