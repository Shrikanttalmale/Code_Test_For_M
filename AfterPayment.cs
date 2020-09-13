using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
   public class AfterPayment
    {
        public static void Main(string[] args)
        {
           if(args.Length==0)
            {
                Console.WriteLine("Please enter the payment type");
                Console.ReadLine();
            }
           else
            {
                AfterPayment af = new AfterPayment();
                string isActionDone = af.TakeActionAfterPaymentForPhyscialProd(args[0].ToString());
            }
        }    

        public string TakeActionAfterPaymentForPhyscialProd(string paymentType)
        {
            ///Code to generate a packaging slip for shippins goes here
            return "Physical";
        }

        public string TakeActionAfterPaymentForBood(string paymentType)
        {
            ///Create duplicate packing slip for royality department
            return "Book";
        }

        public string TakeActionAfterPaymentForMembership(string paymentType)
        {
            ///Activate membership code goes here
            return "Member";
        }



        public bool TakeAction()
        {
            return true;
        }
    }
}
