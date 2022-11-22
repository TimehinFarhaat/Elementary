using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question8
    {
        static void Main()
        {
            Digit();
        }


        static void Digit()
        {
            Console.Write("Enter lenght: ");
            long length = long.Parse(Console.ReadLine());
            long [] array=new long[length];
            for (int i = 0; i <length ; i++)
            {
                Console.Write("Enter number: ");
                array[i] = long.Parse(Console.ReadLine());

                for (int j = 0; j < length; j++)
                {
                    Console.Write("Enter number: ");
                    array[j] = long.Parse(Console.ReadLine());

                    long sum = (array[i] + array[j]) % 10;
                    Console.WriteLine(sum +" ");
                }
            }
            
        }
    }
}
