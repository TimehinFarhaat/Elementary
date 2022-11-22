using System;


namespace Chapter3
{
    class Number3
    {
        public static void Answers ()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            bool digit = ((num / 100) % 10) == 7;
            Console.WriteLine(digit);
        }
    }
}