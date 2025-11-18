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
            int start = 21;
            int end = 20;
            do
            {
                Console.WriteLine(start); // 30
                start += 2;//start = start+2 // start= 32

            } while (start <= end);
        }
    }
}
