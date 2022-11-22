using System;


namespace Chapter3
{
    class Number5
    {
        public static void Answers ()
        {
            Console.Write("Enter side: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the other side: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            int s = ((a + b) * h) / 2;
            Console.WriteLine($"The area is {s}");
        }
    }
}