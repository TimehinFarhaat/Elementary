using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number8
    {
        public static void Answers()
        {

            Console.Write("Enter  Number (number> or equals to 0): ");
            int N = int.Parse(Console.ReadLine());
            int a = 1;
            int d = N+1;
            int r = 1;
            int b = 2 * N;
            int w = 1;
            for (int i = N; i > 0; i--)
            {
                a *= i;
            }

            for (int i = d; i > 0; i--)
            {
                r *= i;
            }

            for (int i = b; i > 0; i--)
            {
                w *= i;
            }

            float C = (w / (r * a));
            Console.WriteLine(C);
        }
    }
}
