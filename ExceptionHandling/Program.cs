using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            SendACurrier();
            Console.ReadKey();
        }

        public static void SendACurrier()
        {
            var currier = new Currier("Agent");

            try
            {
                currier.Deliver(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("********** The will start again with another transport *************");
                SendACurrier();
            }
        }
    }
}
