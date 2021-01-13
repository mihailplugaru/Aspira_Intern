using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegatesApp1
{
    public class MarketingDepartment
    {
        public delegate bool DoAfterGetAddresses(List<CustomerAddress> listOfAddresses); 
        public bool ExecuteNewCampaign(decimal budget)
        {
            AddressProvider myAddressProvider = new AddressProvider();

            List<CustomerAddress> listOfAddresses = myAddressProvider.GetAddressesNewProspects();
            
            DoAfterGetAddresses doAfterGetAddresses;

            if (budget < 10000)
            {
                BallpenCompany myBallpenCompany = new BallpenCompany();
                doAfterGetAddresses = myBallpenCompany.SendBallPens;
            }
            else
            {
                CoffeeCupCompany myCoffeeCupCompany = new CoffeeCupCompany();
                doAfterGetAddresses = myCoffeeCupCompany.SendCoffeeCups;
            }

            return myAddressProvider.HandleCompaign(doAfterGetAddresses);
        }
    }
}
