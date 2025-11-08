using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class27
    {
        static void Main(string[] args)
        {
            // write a program to generate number from 1 to given number.

            int i = 1;

            Console.Write("Enter a number: "); 
            int num = int.Parse(Console.ReadLine());// num = 5

            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
