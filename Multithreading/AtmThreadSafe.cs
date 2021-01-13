using System;
using System.Threading;

namespace Multithreading
{
    class AtmThreadSafe
    {
        private int total = 100;
        private object myLock = new object();

        public void Withdraw(int amount)
        {
            lock (myLock)
            {
                if (total >= amount)
                {
                    total -= amount;
                    Console.WriteLine("Someone  --- WITHDRAWED {0} .  There is still {1} available", amount, total);
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money in ATM...");
                }
            }
        }

        public void Deposit(int amount)
        {
            lock (myLock)
            {
                total += amount;
                Console.WriteLine("Someone  +++ DEPOSITED  {0} ,  now there is {1} available", amount, total);
                if (total < 30)
                {
                    Thread.Sleep(5000);
                }
            }
        }
    }
}

