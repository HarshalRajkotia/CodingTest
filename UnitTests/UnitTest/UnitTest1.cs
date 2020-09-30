using NUnit.Framework;
using CodingTest;
using CodingTest.Purchases;

namespace UnitTestForCodingTest
{
    [TestFixture]
    public class UnitTest1
    {
        ConcretePurchaseFactory factory;
        IPurchase Purchase;

        [SetUp]
        public void setup()
        {
            factory = new ConcretePurchaseFactory();
        }

        [Test]
        public void TestMethod_ForBook()
        {
            Purchase = factory.GetPurchaseType("Book");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);

        }

        [Test]
        public void TestMethod_ForPhysicalProduct()
        {
            Purchase = factory.GetPurchaseType("PhysicalProduct");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);

        }

        [Test]
        public void TestMethod_ForMembership()
        {
            Purchase = factory.GetPurchaseType("Membership");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);

        }

        [Test]
        public void TestMethod_ForUpgradeMembership()
        {
            Purchase = factory.GetPurchaseType("UpgradeMembership");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);

        }

        [Test]
        public void TestMethod_ForVideo()
        {
            Purchase = factory.GetPurchaseType("Video");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);

        }
    }
}
