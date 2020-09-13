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

            Console.WriteLine("Please enter the payment type: \n 1 for Physical Product \n 2 for Books \n 3 for Membership");
           
            int choice = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Your made payment for : " + choice);
           

            if(choice==1)
            {
                PhysicalProduct p = new PhysicalProduct();
                 p.TakeActionAfterPayment();
            }
           else if( choice == 2)
            {
                Books b = new Books();
                b.TakeActionAfterPayment();
            }
            else if (choice == 3)
            {
                Membership m= new Membership();
                m.TakeActionAfterPayment();
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
