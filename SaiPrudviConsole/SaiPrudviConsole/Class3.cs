using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name : ");
            string ename = Console.ReadLine();
            Console.Write("Enter Employee ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary : ");
            int sal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Employee ID :{id}\nEmployee Name : {ename}\nEmployee Salary : {sal}");


        }
    }
}
