﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class17
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a}\tb = {b}"); // 10  20
            a += b;
            Console.WriteLine($"a = {a}"); // 30
            a -= b;// a = a-b
            Console.WriteLine($"a = {a}");// 10
            a *= b;
            Console.WriteLine($"a = {a}");// 200
            a /= b;
            Console.WriteLine($"a = {a}");// 10





        }
    }
}
