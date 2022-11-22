using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Number3
    {
        static void Answers()
        {
            bool Equal = true;
            Console.Write("Enter the length of first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] Arr=new int[length];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("Enter element {0}: ");
                Arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second array: ");
            if (length != int.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Arrays have different length");
            }
            else
            {
                int []Arrb=new int[length];
                for (int i = 0; i < Arrb.Length; i++)
                {
                    Console.WriteLine("Enter element {0}: ");                }
            }
        }
    }
}
