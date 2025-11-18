using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class36
    {
        static void Main(string[] args)
        {
            //Write a program toq check given number is palindrom

            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); //123
            int copy = num;  // copy = 123

            int rev = 0;
            while (num > 0)
            {
                int ld = num % 10;
                rev = rev * 10 + ld;
                num = num / 10;
            }
            if (copy == rev)
            {
                Console.WriteLine("Given number is Palindrome");
            }
            else
            {
                Console.WriteLine("Given number is not a Palindrome");
            }






        }
    }
}
