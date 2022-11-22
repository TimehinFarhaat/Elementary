using System;


namespace Loop
{
    class Number2
    {
        public static void Answers ()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            bool divide = true;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}