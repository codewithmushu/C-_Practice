using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class NthHarmonicNumber
    {
        public static void CalcNthHarmonicNumber()
        {
            Console.WriteLine("Please provide value for N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("N must be greater than 0 ");
            }
            else
            {
                double Harmonic_sum = 0.0;
                for (int i = 0; i <= N; i++) 
                {
                    Harmonic_sum = 1.0 / i;
                }
                Console.WriteLine("The Nth Harmonic value is : {0}",Harmonic_sum);
            }
        }
    }
}
