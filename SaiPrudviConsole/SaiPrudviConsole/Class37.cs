using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiPrudviConsole
{
    internal class Class37
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            //=========================================count digit
            int count = 0;
            while (num > 0) // num = 153 15>0 1>0 0>0
            {
                int ld = num % 10;// ld = 3 ld = 5 ld = 1
                count++;
                num = num / 10;// num = 15 nu = 15/10 num = 1 / 10 nu = 0
            }
            num = copy;// count = 3
          //=============================================
               ////separted the value and pvalue sum

            int sum = 0;
            while (num > 0) //153>0 15>0 1>0 0>0
            {
                int lastDigit = num % 10; // ld = 3 ld = 5 ld = 1
                int start = 1;
                int pval = 1;
                while (start <= count) // 1<=3 2<=3 3<=3 4<=3
                {
                    pval = pval * lastDigit; // pva= 1 pva = 1 pva = 1
                    start++; // start = 2 start = 3 start = 4
                }
                sum = sum + pval; // sum = sum = 27  sum = 152 sum = 153
                num = num / 10; // num = 15 num = 1 num = 0


            }

            if(copy == sum)
            {
                Console.WriteLine($"Given number an Armstrong");
            }
            else
            {
                Console.WriteLine($"Given number is not an Armstrong");
            }

        }
    }
}
