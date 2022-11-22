using System;


namespace Chapter3
{
    class Number7
    {
        public static void Answers ()
        {

            Console.Write("Enter the weight:  ");
            int w = int.Parse(Console.ReadLine());
            float  moonW = w * (0.17f);
            Console.WriteLine(moonW);

        }
    }
}