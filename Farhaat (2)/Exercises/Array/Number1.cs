using System;


namespace Array
{
    class Number1
    {
        public static void Answers()
        {
            int[] array=new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5 * i;
                Console.Write(array[i] +" ");
            }
        }
    }
}