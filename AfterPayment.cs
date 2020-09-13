using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{

    public interface ITakeAction
    {
        string TakeActionAfterPayment();
    }
    public class AfterPayment
    {


        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the payment type: \n 1 for Physical Product \n 2 for Books \n 3 for Membership");
           
            int choice = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Your made payment for : " + choice);

             ActionFactory af = new ActionFactory();
            ITakeAction selectedAction = af.GetAfterPaymentAction(choice);
            selectedAction.TakeActionAfterPayment();
           
        }    


        public class PhysicalProduct : ITakeAction
        {
           public string  TakeActionAfterPayment()
            {
                Console.WriteLine("Generated Packaging Slip for Shipping");
                Console.ReadLine();
                return "Physical";
            }
        }

        public class Books : ITakeAction
        {
            public string TakeActionAfterPayment()
            {
                Console.WriteLine("Generated duplicate Packaging Slip for Royality Department");
                Console.ReadLine();
                return "Book";
            }
        }


        public class Membership : ITakeAction
        {
            public string TakeActionAfterPayment()
            {
                Console.WriteLine("Activated Membership");
                Console.ReadLine();
                return "Activate Membership";
            }
        }





        public bool TakeAction()
        {
            return true;
        }
    }

}
