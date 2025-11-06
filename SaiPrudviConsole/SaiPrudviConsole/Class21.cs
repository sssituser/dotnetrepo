using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class21
    {
        static void Main(string[] args)
        {
            //Nested if

            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num < 10)
                {
                    Console.WriteLine($"Given number {num} is +Ve and single Digit");
                }
                else
                {
                    Console.WriteLine($"Given number {num} is +ve but not a single digit");
                }
            }
            else
            {
                Console.WriteLine("Given number  may be 0 or -ve");
            }





        }
    }
}
