using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class29
    {
        static void Main(string[] args)
        {
            int start = 2;
            int end = 20;
            while (start <= end)
            {
                Console.WriteLine(start);
                start += 2;//start = start+2
            }
        }
    }
}
