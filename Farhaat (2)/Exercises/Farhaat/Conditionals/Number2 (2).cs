using System;

namespace Array
{
    class Number2
    {
        public static void Answers ()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            int negativenum = 0;
            if (num < 0)
            {
                negativenum++;
            } 
            if (num1 < 0)
            {
                negativenum++;
            } 
            if (num2 < 0)
            {
                negativenum++;
            }

            if (num==0||num2==0||num1==0)
            {
                Console.WriteLine("0");
            }

            if (negativenum % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else if (negativenum % 2!= 0)
            {
                
                Console.WriteLine("-");
            }
            else
            { 
                Console.WriteLine("+");
            }
        }
    }
}