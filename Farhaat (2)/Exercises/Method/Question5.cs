using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question5
    {
        static void Main()
        {
            Array();
        }


        static void Array()
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array=new int[length];
            bool arr = true;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter numbers:");
                array[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < length-2; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i + 2])
                {
                    arr = true;
                }
                else
                {
                    arr = false;
                }
            }
            Console.WriteLine(arr);
        }
    }
}
