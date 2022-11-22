using System;

namespace Array
{
    class Number3
    {
        public static void Answers()
        {
            Console.Write("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a number");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c && a > c)
                {
                    Console.WriteLine(a);
                }
            }
            else if (b > a)
            {
                if (a > c && b > c)
                {
                    Console.WriteLine(b);
                }
            }
            else if (c > a)
            {
                if (a > b&& c>b)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }

    }
}