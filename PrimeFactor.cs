using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PrimeFactor
    {
        public static void CalcPrimeFactor()
        {
            Console.WriteLine("Enter Number to calculate prime factors : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + n + " are : ");
            for (int i = 2; i <= n ; i++)
            {
                while ( n % i == 0 )
                {
                    Console.WriteLine( i + " ");
                    n /= i;
                }
            }
        }
    }
}
