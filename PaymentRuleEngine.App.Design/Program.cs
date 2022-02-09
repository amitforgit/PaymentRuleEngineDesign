using PaymentRuleEngine.App.Factory;
using PaymentRuleEngine.App.Models;
using System;
using static PaymentRuleEngine.App.Common.Enums;

namespace PaymentRuleEngine.App
{
    /// <summary>
    /// Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool isNotValidData = true;
            PaymentModel payment = new PaymentModel();
            while (isNotValidData)
            {
                try
                {
                    // Get Inputs from Console
                    Console.WriteLine("Please enter 1 for Physical Products: \n Enter 2 for Books: \n Enter 3 for Video: \n Enter 4 for Membership Activation \n Enter 5 to quit");
                    int getUserInput = Convert.ToInt32(Console.ReadLine());
                    if (getUserInput != 5)
                    {
                        OrderTypes productTypes = (OrderTypes)(getUserInput - 1);
                        payment.Type = productTypes;

                        // Check if product type is Membership
                        if (productTypes == OrderTypes.Membership)
                        {
                            Console.WriteLine("Please enter 1 to Activate the membership \n Enter 2 to Update the membership\n");
                            OrderModes orderMode = (OrderModes)(Convert.ToInt32(Console.ReadLine()) - 1);
                            payment.OrderMode = orderMode;
                        }

                        Console.WriteLine("Please enter Amount:");
                        payment.Amount = Convert.ToDecimal(Console.ReadLine());
                        isNotValidData = false;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad Input, try again");
                }
            }
            try
            {
                PaymentFactoryService makePayment = new PaymentFactoryService();
                makePayment.TransactionDone(payment);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Internal Server Error");
            }
        }
    }
}
