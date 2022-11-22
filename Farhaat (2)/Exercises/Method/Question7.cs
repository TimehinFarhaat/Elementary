using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question7
    {
        static void Main()
        {
            Number();
        }


        static void Number()
        {
            Console.Write("Enter numbe 3digit: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                 sum = num % 10;
                int d = num / 10;
                d = num;
                Console.Write(sum);
            }
          
        }
    }
}
