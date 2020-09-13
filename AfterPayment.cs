using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
   public class AfterPayment
    {

        interface ITakeAction
        {
            string TakeActionAfterPayment();
        }

        public static void Main(string[] args)
        {
           if(args.Length==0)
            {
                Console.WriteLine("Please enter the payment type");
                Console.ReadLine();
            }
           //else
           // {
           //     AfterPayment af = new AfterPayment();
           //     string isActionDone = af.TakeActionAfterPaymentForPhyscialProd(args[0].ToString());
           // }
        }    


        public class PhysicalProduct : ITakeAction
        {
           public string  TakeActionAfterPayment()
            {
                return "Physical";
            }
        }

        public class Books : ITakeAction
        {
            public string TakeActionAfterPayment()
            {
                return "Book";
            }
        }


        public class Membership : ITakeAction
        {
            public string TakeActionAfterPayment()
            {
                return "Activate Membership";
            }
        }





        public bool TakeAction()
        {
            return true;
        }
    }

}
