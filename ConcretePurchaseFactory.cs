 namespace CodingTest
 {
     using CodingTest.Purchases;
    public class ConcretePurchaseFactory : PurchaseFactory
    {
        public override IPurchase GetPurchaseType(string purchaseType)
        {
           switch (purchaseType)
           {
                case "PhysicalProduct":
                 return new PhysicalProduct();
                case "Book":
                return new Book();
                 case "Membership":
                return new Membership();
                 case "UpgradeMembership":
                return new UpgradeMembership();
                 case "Video":
                return new Video();
                default:
                throw new System.Exception(string.Format("Purchase '{0}' cannot be created", purchaseType));
           }
        }
    }
}