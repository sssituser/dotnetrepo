using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"a = {a++}"); // 11
            Console.WriteLine($"a = {a}"); // 11

            int b = 20;
            Console.WriteLine($"b = {++b}");
            Console.WriteLine($"b = {b}");

        }
    }
}
