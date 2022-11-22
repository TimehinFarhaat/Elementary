using System;


namespace test
{
    class Number13
    {
        public static void Answer ()
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a+ "is a and b is b  " + b);
        }
    }
}