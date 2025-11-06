using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class25
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine()); //a=5

            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());// b=6

            Console.WriteLine("==========MENU============");

            Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\nEnter Choce:");
            string ch = Console.ReadLine();



            switch (ch)
            {
                case "+":
                    Console.WriteLine($"Sum is {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Sub is {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Mul is {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Quo is {a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;


            }

        }
    }
}
