using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number9
    {
        public static void Answers()
        {

            Console.Write("Enter  N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int a = 1;
            double d = 1;
            double h = 1;
            for (int i = 1; i <= N; i++)
            {
                a *= i;
                d = Math.Pow(k, i);
                h +=(a / d);

            }
            Console.WriteLine(h);
           

        }
    }
}
