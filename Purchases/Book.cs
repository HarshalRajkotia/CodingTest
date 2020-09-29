using System.Collections.Generic;

namespace  CodingTest.Purchases
{
    public class Book : PhysicalProduct
    {
        public override List<string> Actions()
        {
            List<string> listOfActions = new List<string>();
            listOfActions.Add("Generate the packing slip for shipping");
            listOfActions.Add("Create the duplicate packing slip for Royalty department");
            listOfActions.Add("Generate the commission payment to the agent");
            return listOfActions;
        }
    }
}