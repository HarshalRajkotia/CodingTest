namespace  CodingTest.Purchases
{
    using System.Collections.Generic;
    public class Video : PhysicalProduct
    {
         public override List<string> Actions()
        {
            List<string> listOfActions = new List<string>();
            listOfActions.Add("Generate the packing slip for shipping");
            listOfActions.Add("Add Free First AID kit video to the packing slip (result of a court decision in 1997)");
            return listOfActions;
        }
    }
}