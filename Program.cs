using System;
using CodingTest.Purchases;
namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to online purchase system");
            
            ConcretePurchaseFactory cFactory = new ConcretePurchaseFactory();

            do
            {
                Console.WriteLine("Enter the Purchase Type");

                string type = Console.ReadLine();

                IPurchase Purchase = cFactory.GetPurchaseType(type);

                var actions = Purchase.Actions();

                actions.ForEach(a=> {Console.WriteLine(a);}); 

                Console.WriteLine("Type Exit to complete the purchase or press Enter to continue");
            }while(Console.ReadLine().ToLower() != "exit" );
        }
    }
}
