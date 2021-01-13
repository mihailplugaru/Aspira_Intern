using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegatesApp1
{
    public class MarketingDepartment
    {
        public bool ExecuteNewCampaign(decimal budget)
        {
            AddressProvider myAddressProvider = new AddressProvider();

            List<CustomerAddress> listOfAddresses = myAddressProvider.GetAddressesNewProspects();

            bool success;
            if (budget < 10000)
            {
                success = myAddressProvider.MySendBallPens();
            }
            else
            {
               success = myAddressProvider.MySendCoffeeCups();
            }

            return success;
        }
    }
}
