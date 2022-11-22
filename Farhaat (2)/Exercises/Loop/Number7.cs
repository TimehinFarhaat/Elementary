using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number7
    {
        public static void Answers()
        {

            Console.Write("Enter  N(number>k>1): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter k(k>1 and less than number): ");
            int k = int.Parse(Console.ReadLine());
            int a = 1;
            int d = 1;
            int s = 1;
            for (int i = 1; i <= N; i++)
            {
                a *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                d *= i;
            }
            for (int i = 1; i < N-k; i++)
            {
                s *= i;
            }
            Console.WriteLine((a*d)/s);
        }
    }
}
