using System;
using System.ComponentModel;


namespace Chapter3
{
    class Number4
    {
        public static void Answers ()
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            bool bit = (num >> 2 == 0 | num >> 2 == 1);
            Console.WriteLine(bit);
        }
    }
}