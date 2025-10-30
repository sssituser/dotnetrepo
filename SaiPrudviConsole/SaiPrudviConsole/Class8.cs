using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dollars : ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"{d} dollars = {d * 87} rupees");
        }
    }
}
