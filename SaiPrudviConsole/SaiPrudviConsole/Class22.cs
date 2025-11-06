using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class22
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Sub 1 Marks  : ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub 2 Marks  : ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub 3 Marks  : ");
            int s3 = int.Parse(Console.ReadLine());
            string res = string.Empty;

            res = s1 > 34 && s2 > 34 && s3 > 34 ? "Passed" : "Failed";
            int avg = (s1 + s2 + s3) / 3;

            if(res=="Passed" && avg >= 66)
            {
                Console.WriteLine("Distintion");
            } else 
            if(res=="Passed" && avg<66 && avg >= 56)
            {
                Console.WriteLine("First Division");
            } else
            if (res == "Passed" && avg < 56 && avg >= 44)
            {
                Console.WriteLine("Second Division");
            } else
            if (res == "Passed" && avg < 44 && avg >= 35)
            {
                Console.WriteLine("Third Division");
            }
            else
            {
                Console.WriteLine("Studen Failed");
            }
        }
    }
}
