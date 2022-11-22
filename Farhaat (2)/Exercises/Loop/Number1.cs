using System;


namespace Loop
{
    class Number1
    {
        public static void Answers()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <=N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}