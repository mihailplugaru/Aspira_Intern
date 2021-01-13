using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegatesApp1
{
    public class CoffeeCupCompany
    {
        public bool SendCoffeeCups(List<CustomerAddress> listOfAddresses)
        {
            foreach (CustomerAddress address in listOfAddresses)
            {
                Console.WriteLine("Sending CoffeCups to City: {0}, Street: {1}", address.City, address.Street);
            }

            return true;
        }
    }
}
