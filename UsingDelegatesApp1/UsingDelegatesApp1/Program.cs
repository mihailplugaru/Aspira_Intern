using System;
using System.Collections.Generic;

namespace UsingDelegatesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingDepartment myDepartment = new MarketingDepartment();

            Console.WriteLine("What's the budget?");
            int budget = Convert.ToInt32(Console.ReadLine());

            bool success = myDepartment.ExecuteNewCampaign(budget);
            Console.WriteLine("The new marketing campaign has {0} !", success == true ? "succeeded" : "failed");
        }

    }
}
