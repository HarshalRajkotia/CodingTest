using CodingTest.Purchases;
 namespace CodingTest
 {
    public abstract class PurchaseFactory
    {
        public abstract IPurchase GetPurchaseType(string purchaseType);
    }
 }