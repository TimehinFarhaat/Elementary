using System;


namespace Chapter3
{
    class Number14
    {
        public static void Answers()
        {

            for (int i = 1; i <=100; i++)
            {
                bool prime = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}