using System;

namespace Array
{
    class Number4
    {
        public static void Answers ()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num < num1 && num < num2)
            {
                if (num1 < num2)
                {
                    Console.WriteLine($"{num2}, {num1}, {num}");
                }
                else
                {
                    Console.WriteLine($"{num1}, {num2}, {num}");
                }
            }
            else if (num1 < num && num1 <num2)
            {
                if (num < num2)
                {
                    Console.WriteLine($"{num2}, {num}, {num1}");
                }
                else
                {
                    Console.WriteLine($"{num}, {num2}, {num1}");
                }
            }
            else if (num2 < num && num2 < num1)
            {
                if (num<num1)
                {
                    Console.WriteLine($"{num1}, {num}, {num2}");
                }
                else
                {
                    Console.WriteLine($"{num1}, {num}, {num2}");
                }
            }
            else
            {
                Console.WriteLine("some are equal");
            }
        }
    }
}