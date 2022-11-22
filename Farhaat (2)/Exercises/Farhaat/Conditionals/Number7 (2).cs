using System;

namespace Array
{
    class Number7
    {
        public static void Answers ()
        {

            int max = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                int no = int.Parse(Console.ReadLine());
                if (no > max)
                {
                    max = no;
                }
            }
            Console.WriteLine(max);
        }

    }
}