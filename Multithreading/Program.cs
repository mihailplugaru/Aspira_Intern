using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmThreadSafe atm = new AtmThreadSafe();
            int withdrawAmount = 15;
            int depositAmount = 5;

            atm.Withdraw(withdrawAmount);
            atm.Deposit(depositAmount);

            while (true)
            {
                ThreadStart withdraw1 = new ThreadStart(() => atm.Withdraw(withdrawAmount));
                ThreadStart withdraw2 = new ThreadStart(() => atm.Withdraw(withdrawAmount));
                ThreadStart withdraw3 = new ThreadStart(() => atm.Withdraw(withdrawAmount));
                ThreadStart deposit1 = new ThreadStart(() => atm.Deposit(depositAmount));
                new Thread(withdraw1).Start();
                new Thread(withdraw2).Start();
                new Thread(withdraw3).Start();
                new Thread(deposit1).Start();
            }
        }
    }
}

