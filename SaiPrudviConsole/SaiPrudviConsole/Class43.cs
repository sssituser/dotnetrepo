using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class43
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int start = 1; start <= num; start++) 
            {

                for(int i = 1; i <= start; i++)
                {
                    Console.Write($"{i}\t"); //1   2     
                }
                Console.WriteLine();
            }
        }
    }
}
