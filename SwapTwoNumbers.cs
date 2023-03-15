using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SwapTwoNumbers
    {
        public static void DisplaySwappedNumbers()
        {
            int a = 87 , b = 45;

            Console.WriteLine("Before Swap a = " +a+ " b = " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swap a = " + a + " b = " + b);
            
        }
    }
}
