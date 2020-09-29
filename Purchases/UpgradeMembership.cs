namespace  CodingTest.Purchases
{
    using System.Collections.Generic;
    public class UpgradeMembership : Membership
    {
        public override List<string> Actions()
        {
            List<string> listOfActions = new List<string>();
            listOfActions.Add("Upgrade the membership");
            listOfActions.Add("E-mail the owner and inform them of the activaiton/upgrade");
            return listOfActions;
        }
    }
}