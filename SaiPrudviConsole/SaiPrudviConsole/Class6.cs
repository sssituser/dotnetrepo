using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value  : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value  : ");
            int  b = int.Parse(Console.ReadLine());
            Console.WriteLine($"sum : {a+b}\nsub : {a-b}\nmul : {a*b}\nquo : {a/b}\nrem : {a%b}");
        }
    }
}
