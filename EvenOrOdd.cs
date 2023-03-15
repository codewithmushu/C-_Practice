using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class EvenOrOdd
    {
        public static void CheckNumEvenOrOdd()
        {
            Console.WriteLine("Enter number to check wheather it is even or odd");
            int num =Convert.ToInt32(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("{0} is even number.", num);
            }
            else
            {
                Console.WriteLine("{0} is odd number.", num);
            }
        }
    }
}
