using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            // Write a program to read 2 Integers,read 2 float values,and boolean value
            //display them
            Console.Write("Enter a value : ");
            int a =  int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int .Parse(Console.ReadLine());
            Console.Write("Enter float value : ");
            float f1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Another Float value : ");
            float f2 = float.Parse(Console.ReadLine());
            Console.Write("Enter boolean value : ");
            bool bl = bool.Parse(Console.ReadLine());
            Console.WriteLine($"{a}   {b}   {f1}   {f2}   {bl}");

        }
    }
}
