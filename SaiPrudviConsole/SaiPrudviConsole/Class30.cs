using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class30
    {
        static void Main(string[] args)
        {
            
            int start = 1;
            int x = 0;
            Console.Write("Enter a value : "); // 3
            int num = int.Parse(Console.ReadLine()) ;
            while (start <= num) // 1<=3  2<=3 3<=3 4<=3
            {
                Console.WriteLine(start); // 1,2,3
                x = x + start; // sum = 1 sum = 3 sum = 6
                start++; // start = 2,3,4
            }
            Console.WriteLine($"Sum is {x}");
        }
    }
}
