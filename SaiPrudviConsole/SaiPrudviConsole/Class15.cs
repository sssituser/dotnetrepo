using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter boolean value :");
            bool bl =bool.Parse(Console.ReadLine());
            string res = bl ? "Hi" : "bye";
            Console.WriteLine(res);
        }
    }
}
