using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class CalcPowerOfTwo
    {
        //This program takes a command-line argument N and prints a table of the
        //powers of 2 that are less than or equal to 2^N.
        public static void PowerOfTwo()
        {
            //Console.WriteLine(" Please provide an integer value for Num : ");
            int Num = 2;
            Console.WriteLine("Please provide power : ");
            int power = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("Powers of 2 that are less than or equal to 2^N: ");
                double result = 1;
                for (int i = 0; i <= power; i++) 
                {
                    result *= Num;
                    Console.WriteLine($"{Num}^{i} = {result}");
                }
                
            }
        }
    }
}
