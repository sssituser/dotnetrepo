using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"{a>b}   {a>=b}   {a<b}     {a<=b}   {a==b}  {a!=b} ");
          
            Console.WriteLine($"{a}>{b}:{a > b}  {a}>={b}:{a >= b}  {a}<{b}:{a < b}  {a}<={b}:{a <= b} {a}=={b}:{a == b} {a}!={b}:{a != b}");
            Console.WriteLine($"a>b :{a > b}  a>=b :{a >= b}  a<b :{a < b}  a<=b :{a <= b} a==b  :{a == b} a!=b {a != b}");
        }
    }
}
