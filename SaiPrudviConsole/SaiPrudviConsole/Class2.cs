using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Subject 1 Marks : ");
            int marks1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject 2 Marks : ");
            int marks2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject 3 marks : ");
            int marks3 = int.Parse(Console.ReadLine());

            Console.Write("Enter Attendance percentage : ");
            float per=float.Parse(Console.ReadLine());



            Console.WriteLine($"Name : {name}\nMarks 1 : {marks1}\nMarks 2 : {marks2}\nMarks 3 : {marks3}\nAttendance : {per}");





        }
    }
}
