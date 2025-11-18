using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class33
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 6
            int start = 1;
            int sum = 0;
            while (start < num)  //1<6 2<6 3<6 4<6 5<6 6<6
            {
                if(num%start == 0)
                {
                    sum = sum + start;// sum = 1 sum =3 sum = 6
                }
                start++;
            }

            if (num == sum)
            {
                Console.WriteLine($"give num {num} is perfect number ");
            }
            else
            {
                Console.WriteLine($"give num {num} is not a perfect number ");
            }
        }
    }
}
