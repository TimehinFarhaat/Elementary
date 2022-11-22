using System;

namespace Array
{
    class  Number1
    {
        public static void Answers()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num > num1)
            {
                int a = num;
                num = num1;
                num1 = a;
                Console.WriteLine($"First number is {num} and the second number is {num1}");
            }
            else
            {
                Console.WriteLine($"{num} is not greater than {num1}");
            }
        }
    }
}