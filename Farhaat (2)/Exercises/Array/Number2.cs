using System;


namespace Array
{
    class Number2
    {
        public static void Answers ()
        {
            bool array = true;
            char[] A = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] B =new char[5]{ 'a', 'b', 'c', 'd', 'e' };
            if (A.Length > B.Length)
            {
                Console.WriteLine("Second arrray is lexographically first");
            }
            else if (A.Length < B.Length)
            {
                Console.WriteLine("First array is lexographically first");
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] < B[i])
                    {
                        Console.WriteLine("First array is lexographically first");
                        array = false;
                        break;
                    }

                    if (A[i] > B[i])
                    {
                        Console.WriteLine("Second array is lexographically first");
                        array = false;
                        break;

                    }



                }

                if (array)
                {
                    Console.WriteLine("Array are lexographically equal");
                }
            }
        }
    }
}