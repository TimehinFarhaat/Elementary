using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Number10
    {
        public static void Answers()
        {
            Console.Write("Enter the number (number less than 20):  ");
            int nom = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nom; i++)
            {
                for (int j = i; j <=(i+nom-1); j++)
                {
                    Console.Write( j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
