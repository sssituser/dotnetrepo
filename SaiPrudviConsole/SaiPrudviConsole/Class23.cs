using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class23
    {
        static void Main(string[] args){
       
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine()); //a=5
            
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());// b=6
        abc:
            Console.WriteLine("==========MENU============");

            Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\nEnter Choce:");
            int ch = int.Parse(Console.ReadLine());
            
          

            switch (ch)
            {
                case 1:
                    Console.WriteLine($"Sum is {a+b}");
                    goto abc;
                case 2: Console.WriteLine($"Sub is {a - b}");
                    goto abc;
                case 3: Console.WriteLine($"Mul is {a*b}"); 
                   goto abc;
                case 4: Console.WriteLine($"Quo is {a/b}");
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;


            }

        }
    }
}
