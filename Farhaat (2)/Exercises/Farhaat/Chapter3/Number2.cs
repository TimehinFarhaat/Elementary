using System;


namespace Chapter3
{
    class Number2
    {
        public static void Answers ()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            bool divisible = (num % 5 == 0 && num % 7== 0);
            Console.WriteLine(divisible);
        }
    }
}