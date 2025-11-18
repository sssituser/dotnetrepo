using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class41
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            for(int start = 1; start <= 20; start++)
            {
                Console.WriteLine($"{num}  x {start} = {num*start} ");
            }


        }
    }
}
