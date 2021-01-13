using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegatesApp1
{
    public class AddressProvider
    {
        private List<CustomerAddress> listOfAddresses = new List<CustomerAddress>();
        public List<CustomerAddress> GetAddressesNewProspects()
        {
            listOfAddresses.Add(new CustomerAddress() { City = "City_1", Street = "Street_1" });
            listOfAddresses.Add(new CustomerAddress() { City = "City_2", Street = "Street_2" });
            listOfAddresses.Add(new CustomerAddress() { City = "City_3", Street = "Street_3" });
            listOfAddresses.Add(new CustomerAddress() { City = "City_4", Street = "Street_4" });
            listOfAddresses.Add(new CustomerAddress() { City = "City_5", Street = "Street_5" });

            return listOfAddresses;
        }

        public bool MySendBallPens()
        {
            return BallpenCompany.SendBallPens(listOfAddresses);
        }

        public bool MySendCoffeeCups()
        {
            return CoffeeCupCompany.SendCoffeeCups(listOfAddresses);
        }
    }
}
