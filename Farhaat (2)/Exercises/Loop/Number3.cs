using System;


namespace Loop
{
    class Number3
    {
        public static void Answers ()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Enter a number:");
                int n = int.Parse(Console.ReadLine());
                if (n < min)
                {
                    min = n;
                }

                if (n>max)
                {
                    max = n;
                }

            }
            Console.WriteLine($"The greatest is {max} and the smallest {min}");
        }
    }
}