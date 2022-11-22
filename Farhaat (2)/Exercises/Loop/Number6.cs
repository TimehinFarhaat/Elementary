using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number6
    {

        public static void Answers()
        {

            Console.Write("Enter  Number(number>k>1):");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter k(K>1):");
            int k = int.Parse(Console.ReadLine());
            int a = 1;
            int d = 1;
            for (int i = 1; i <= N; i++)
            {
                a *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                d *= i;
            }
            Console.WriteLine(a / d);
        }
    }
}
