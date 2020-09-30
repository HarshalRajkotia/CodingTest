using System;
using CodingTest.Purchases;
namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to online purchase system");
            Console.WriteLine("Please type below Product name exactly to initiate the purchase");
            Console.WriteLine(" 1. PhysicalProduct \n 2. Book \n 3. Membership \n 4. UpgradeMembership \n 5. Video");

            ConcretePurchaseFactory cFactory = new ConcretePurchaseFactory();

            do
            {
                Console.WriteLine("Enter the Purchase Type");

                string type = Console.ReadLine();
                try
                {
                    IPurchase Purchase = cFactory.GetPurchaseType(type);

                    var actions = Purchase.Actions();

                    actions.ForEach(a => { Console.WriteLine(a); });

                  
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Purchase"))
                    {
                        Console.WriteLine("Invalid Purchase");
                    }
                    
                }

                Console.WriteLine("Type Exit to complete the purchase or press Enter to continue");
            } while(Console.ReadLine().ToLower() != "exit" );
        }
    }
}
