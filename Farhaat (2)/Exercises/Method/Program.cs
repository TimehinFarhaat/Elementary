using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());



            Console.Write("Enter a number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num4 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Because num1 is greater than num2 their sum is {num1 + num2}");
            }
            if (num2 > num1)
            {
                Console.WriteLine($"Because num2 is greater than num1 their difference is {num2 - num1}");
            }

            if (num3 > num4)
            {
                Console.WriteLine($"Because num3 is greater than num 4 their sum is {num3 + num4}");
            }

            if (num4 > num3)
            {
                Console.WriteLine($"Because num4 is greater than num3 their difference is {num4 - num3}");
            }





























































        }
    }
}
