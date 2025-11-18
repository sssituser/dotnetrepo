using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class46
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 45, 50,90,67 };

            Console.WriteLine($"Total elements present in the array are :{a.Length}");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i}--->{a[i]}");
            }

        }
    }
}
