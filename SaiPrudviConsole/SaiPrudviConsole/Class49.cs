using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class49
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[] physicsmarks = new int[3];
            int[] mathsmarks = new int[3];
            int[] social = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Name : ");
                names[i] =Console.ReadLine();
                Console.Write("Enter Physics Marks : ");
                physicsmarks[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Mathsmarks : ");
                mathsmarks[i] = int.Parse(Console.ReadLine()) ;
                Console.Write("Enter Social Marks : ");
                social[i] = int.Parse(Console.ReadLine()) ; 
            }
            Console.WriteLine("Student Reslut is ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Name\tPhysics\tMaths\tSocial\t\tResult");
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                if (mathsmarks[i] > 34 && physicsmarks[i]>34&& social[i] > 34)
                {
                    Console.WriteLine($"{names[i]}\t{physicsmarks[i]}\t{mathsmarks[i]}\t{social[i]}\t{physicsmarks[i] + mathsmarks[i] + social[i]}\tPassed");
                }
                else
                {
                    Console.WriteLine($"{names[i]}\t{physicsmarks[i]}\t{mathsmarks[i]}\t{social[i]}\t{physicsmarks[i] + mathsmarks[i] + social[i]}\tFailed");
                }
            }
            Console.WriteLine("-----------------------------------------------------");




        }
    }
}
