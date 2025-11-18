using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class28
    {
        // write a program to generate number from the given number to  1
        // 5 4,3,2,1
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // 5

            int end = 1;






            do
            {
                Console.WriteLine(num);// 5
                num--;
            }
            while (num >= end);





        }
    }
}
