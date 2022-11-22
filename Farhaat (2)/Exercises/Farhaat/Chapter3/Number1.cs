using System;


namespace Chapter3
{
    class Number1
    {
        public static void Answers()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            bool even = (num % 2 == 0);
            Console.WriteLine(even);
        }
    }
}