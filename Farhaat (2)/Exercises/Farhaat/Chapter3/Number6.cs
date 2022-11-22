using System;


namespace Chapter3
{
    class Number6
    {
         public static void Answers()
        {

            Console.Write("Enter the side of a rectangle:  ");
            float side = float.Parse(Console.ReadLine());
            Console.Write("Enter the height of a rectangle: ");
            float height = float.Parse(Console.ReadLine());
            float perimeter = 2 * (side + height);
            float area = side * height;
            Console.WriteLine("The perimeter is " + perimeter + " and the area is " + area);
        }
    }
}