using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class32
    {
        static void Main(string[] args)
        {
            // Write a program to find the factors of a give number.
            // num = 8  1,2,3,4,5,6,7,8,9,10
            int start = 1;
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            while (start <= num) //1<=8 2<=8 3<=8 4<=8
            {
                                        
                if (num % start == 0)
                {
                    Console.WriteLine(start); //1,2,4
                }
                start++;
            }



        }
    }
}
