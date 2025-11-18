using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class38
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number  : ");
            int num = int.Parse(Console.ReadLine()); // num=3
            for (int start = 1; start <= num; start++) // 2,3
            {
                Console.WriteLine(start);// 1,2
            }
        }
    }
}
