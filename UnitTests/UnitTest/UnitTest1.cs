using NUnit.Framework;
using CodingTest;
using CodingTest.Purchases;
using System;

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
            Assert.IsTrue(actions.Count == 3);

        }

        [Test]
        public void TestMethod_ForPhysicalProduct()
        {
            Purchase = factory.GetPurchaseType("PhysicalProduct");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);
            Assert.IsTrue(actions.Count == 2);
        }

        [Test]
        public void TestMethod_ForMembership()
        {
            Purchase = factory.GetPurchaseType("Membership");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);
            Assert.IsTrue(actions.Count == 2);
        }

        [Test]
        public void TestMethod_ForUpgradeMembership()
        {
            Purchase = factory.GetPurchaseType("UpgradeMembership");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);
            Assert.IsTrue(actions.Count == 2);
        }

        [Test]
        public void TestMethod_ForVideo()
        {
            Purchase = factory.GetPurchaseType("Video");
            var actions = Purchase.Actions();
            Assert.IsNotNull(actions);
            Assert.IsTrue(actions.Count == 2);
        }

        [Test]
        public void TestMethod_ForInvalidPurchase()
        {         
            Assert.Throws(Is.TypeOf<Exception>()
                .And.Message.EqualTo("Purchase 'XYZ' cannot be created"),
              () => factory.GetPurchaseType("XYZ"));            
        }
    }
}
