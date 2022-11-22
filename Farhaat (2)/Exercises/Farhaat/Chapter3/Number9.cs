using System;


namespace Chapter3
{
    class Number9
    {
        public static void Answer ()
        {

            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            bool point = ((x * x) + (y * y) <= 5 * 5);
            Console.WriteLine(point);

        }
    }
}