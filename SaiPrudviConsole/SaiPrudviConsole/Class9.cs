using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Meters : ");
            double mts = double.Parse(Console.ReadLine());
            Console.WriteLine($"{mts} meters equals to {mts/1000} kilo meters");
        }
    }
}
