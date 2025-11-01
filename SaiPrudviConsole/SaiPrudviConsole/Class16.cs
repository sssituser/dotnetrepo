using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject 1 Marks : ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject 2 Marks : ");
            int s2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject 3 Marks : ");
            int s3 = int.Parse(Console.ReadLine());

            string res = s1 >= 35 && s2 >= 35 && s3 >= 35 ? "Hi" : "bye";
            Console.WriteLine(res);
            Console.WriteLine(s1 >= 35 && s2 >= 35 && s3 >= 35 ? "Passed" : "Failed");



        }
    }
}
