using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question6
    {
        static void Main ()
        {
            Array();
        }


        static void Array()
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            bool arr = true;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter numbers:");
                array[i] = int.Parse(Console.ReadLine());

            }

      
            if (array[3] > array[3 -1] && array[3] > array[3 + 1]) 
            {
                    Console.WriteLine(array[3]);
            }
            else 
            {
                    Console.WriteLine(-1);
            }
            

        }
    }       
        
}
