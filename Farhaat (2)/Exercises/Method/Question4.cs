using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question4
    {
        static void Main()
        {
            Console.WriteLine(Array());
        }


        static int  Array()
        {
            Console.Write("Enter the length of numbers: ");
            int length = int.Parse(Console.ReadLine());
            int[] array=new int[length];
            int count = 0;
            for (int i = 0; i <length; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 4)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
