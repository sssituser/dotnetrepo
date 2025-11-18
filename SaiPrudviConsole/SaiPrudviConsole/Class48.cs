using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class48
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"Enter {i + 1} String : ");
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("Entered String are : ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{i+1} String is : {str[i]}");
            }

        }
    }
}
