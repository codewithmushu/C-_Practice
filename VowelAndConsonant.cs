using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class VowelAndConsonant
    {
        public static void CheckVowelAndConsonant()
        {
            char ch;

            Console.WriteLine("Enter any character : ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch =='a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u')
            || (ch =='A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U')) 
            {
                Console.WriteLine(ch + " Is a vowel");

            }
            else if ((ch >=  'A' && ch <= 'Z')|| (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch + " Is a consonent ");
            }
        }
       

    }
}
