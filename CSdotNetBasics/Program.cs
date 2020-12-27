using System;

namespace CSdotNetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string world_Word = new string("bye!");
            world_Word = "World";

            string exclamationMark = "!";
            Console.WriteLine("Hello {0}{1}", world_Word, exclamationMark);

            object exclamationMark_object = exclamationMark[0];
            char exclamationMark_char = (char)exclamationMark_object;

            Console.WriteLine("Hello {0}{1} again!", world_Word, exclamationMark_char);

            Console.ReadKey(); // Hello_World!  part ends here

            double priceOfProductX = 2.00;
            int theSamePriceOfProduct = 2;

            if ((priceOfProductX == theSamePriceOfProduct) && (priceOfProductX != 0))
            {
                Console.WriteLine("Prices are the same!");
            }
            else
            {
                Console.WriteLine("{0} differs from {1} !", priceOfProductX, theSamePriceOfProduct);
            }

            float doubledPrice = theSamePriceOfProduct;
            doubledPrice += (float)priceOfProductX;
            Console.WriteLine("Price was doubled - {0}", doubledPrice);

            Console.ReadKey();  // Types_and_Operations  part ends here

            int var1 = 3;
            int var2 = 7;

            var1 = var2;

        }
    }
}
