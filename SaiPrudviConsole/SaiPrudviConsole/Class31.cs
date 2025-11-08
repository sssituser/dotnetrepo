using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class31
    {
        static void Main(string[] args)
        {
            // Question : Find the Factorial of a given number 

            // num = 5  1*2*3*4*5
            int start = 1;
            Console.Write("Enter a number : "); // 3
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            while (start <= num) 
            {
                Console.WriteLine(start); 
                fact = fact * start;
                start++;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");

        }
    }
}
