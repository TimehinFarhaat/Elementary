using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number11
    {
        public static void Answers()
        {

            Console.Write("Enter  N: ");
            int N = int.Parse(Console.ReadLine());
            int a = 1;
            int count = 0;
            for (int i = N; i > 0; i--)
            {
                a *= i;
            }
            while (a > 0)
            {
                int digit = a % 10;
                int result = a / 10;
                a = result;
                if (digit == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
            

        }
    }
}
