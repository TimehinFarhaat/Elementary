using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number5
    {
        public static void Answers()
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int a = -1;
            int b = 1;
            int c = 0;
            for (int i = 1; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
