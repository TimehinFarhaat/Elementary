using System;

namespace Array
{
    class Number8
    {
        public static void Answers ()
        { 
            Console.WriteLine("Enter choice (1)-string,(2)-double,(3)-int: "); 
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("*");
            }
            if (choice == 2 || choice == 3)
            {
                Console.WriteLine(choice++);
            }
            


        }

    }
}