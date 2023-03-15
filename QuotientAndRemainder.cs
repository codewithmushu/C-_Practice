using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            int dividend = 67, divisor = 5;

            int remainder = dividend % divisor;
            int Quotient = dividend / divisor;

            Console.WriteLine("The dividend {0} and advisor {1} ",dividend,divisor);
            Console.WriteLine("The Quotient is " + Quotient + " The remainder is " + remainder);
        }
    }
}
