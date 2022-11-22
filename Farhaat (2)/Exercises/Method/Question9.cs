using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question9
    {
        static void Main()
        {
            factorial();
            
        }



        static void factorial()
        {
            Console.Write("Enter a number between 1-100:  ");
            long num = long.Parse(Console.ReadLine());
            long fac = 0;
            for (long i = 1; i < num; i++)
            {
                num *= i;
                fac = num;
            }
            Console.WriteLine(fac);
        }

    }
}
