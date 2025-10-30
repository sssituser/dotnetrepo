using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //Read values
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Father Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Gender : ");
            string gen = Console.ReadLine();
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();
            //Display values

            Console.WriteLine($"Name : {name}\tFather Name :{fname}\tGender : {gen}\tAddress : {address}");



        }
    }
}
