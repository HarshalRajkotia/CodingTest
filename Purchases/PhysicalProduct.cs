using System.Collections.Generic;
namespace  CodingTest.Purchases
{
    public class PhysicalProduct : IPurchase
    {
        public virtual List<string> Actions()
        {
            List<string> listOfActions = new List<string>();
            listOfActions.Add("Generate the packing slip for shipping");
            listOfActions.Add("Generate the commission payment to the Agent");
            return listOfActions;
        }
    }
}