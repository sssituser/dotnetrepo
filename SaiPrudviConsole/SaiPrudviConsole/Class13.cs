using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value :");
            int a = int.Parse(Console.ReadLine()); //50
            Console.Write("Enter b value :");
            int b = int.Parse(Console.ReadLine()); //70
            Console.Write("Enter c value :");
            int c = int.Parse(Console.ReadLine());//80

            Console.WriteLine(!(a<50 || b<50 || c<50));

        }
    }
}
