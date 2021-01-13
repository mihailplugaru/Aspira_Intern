using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegatesApp1
{
    public class BallpenCompany
    {
        public static Func<List<CustomerAddress>, bool> SendBallPens = (listOfAddresses) =>
        {
            foreach (CustomerAddress address in listOfAddresses)
            {
                Console.WriteLine("Sending BallPens to City: {0}, Street: {1}", address.City, address.Street);
            }

            return true;
        };
    }
}
