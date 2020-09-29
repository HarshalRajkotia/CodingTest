using System.Collections.Generic;
namespace  CodingTest.Purchases
{
    public class Membership : IPurchase
    {
        public virtual List<string> Actions()
        {
            List<string> listOfActions = new List<string>();
            listOfActions.Add("Activate the membership");
            listOfActions.Add("E-mail the owner and inform them of the activaiton/upgrade");
            return listOfActions;
        }
    }
}