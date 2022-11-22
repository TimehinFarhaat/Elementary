using System;

namespace Array
{
    class Number9
    {
        public static void Answers ()
        {
            Console.WriteLine("Enter a number: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int no3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int no4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int no5 = int.Parse(Console.ReadLine());
            if (no1 + no2 == 0)
            {
                Console.WriteLine($"The subset are {no1} and {no2}");
            }
            if (no1 + no2 + no3 == 0)
            {
                Console.WriteLine($"The subset are {no1}, {no2} and {no3}");
            }
            if (no1 + no2 + no3 + no4 == 0)
            {
                Console.WriteLine($"The subset are {no1}, {no2}, {no3} and {no4}");
            }
            if (no1 + no2 + no3 + no4 +no5 == 0)
            {
                Console.WriteLine($"The subset are {no1}, {no2},{no3},{no4} and {no5}");
            }
            if (no2 + no3  == 0)
            {
                Console.WriteLine($"The subset are  {no2} and {no3} ");
            }
            if ( no2 + no3 + no4 == 0)
            {
                Console.WriteLine($"The subset are  {no2} , {no3} and {no4}");
            }
            if (no2 + no3 + no4 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no2} , {no3}, {no4} and {no5} ");
            }
            if ( no3 + no4 == 0)
            {
                Console.WriteLine($"The subset are  {no3} and {no4}");
            }
            if ( no3 + no4 + no5 == 0)
            {
                Console.WriteLine($"The subset are   {no3} , {no4}, {no5}");
            }
            if ( no4 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no4} and {no5}");
            }
            if (no1 + no3 == 0)
            {
                Console.WriteLine($"The subset are  {no1}  and {no3}");
            }
            if (no1 + no4 == 0)
            {
                Console.WriteLine($"The subset are   {no1} and {no4}");
            }
            if ( no1 + no5 == 0)
            {
                Console.WriteLine($"The subset are   {no1} and {no5}");
            }
            if (no1+ no2 + no4 == 0)
            {
                Console.WriteLine($"The subset are  {no1} , {no2} and {no4}");
            }
            if (no1 + no2 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no1} , {no2} and {no5}");
            }
            if (no1 + no3 + no4 == 0)
            {
                Console.WriteLine($"The subset are  {no1} , {no3} and {no4}");
            }
            if (no1 + no3 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no1} , {no3} and {no5}");
            }
            if (no2 + no4 == 0)
            {
                Console.WriteLine($"The subset are  {no2} and {no4}");
            }
            if (no2 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no2}  and {no5}");
            }
            if (no2 + no4 + no5 == 0)
            {
                Console.WriteLine($"The subset are  {no2} , {no4} and {no5}");
            }
            if ( no3 + no5 == 0)
            {
                Console.WriteLine($"The subset are   {no3} and {no5}");
            }
            

        }

    }
}