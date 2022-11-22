using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


namespace Array
{
    class Number6
    {
        public static void Answers ()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            int D = (b * b) - (4 * a * c);
            if (D == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine(x);
            }
            else if (D > 0)
            {
                double x1 = -b + Math.Sqrt(((b * b) - (4 * a * c)) / (2 *a ));
                double x2 = -b + Math.Sqrt(((b * b) - (4 * a * c)) / (2 *a ));
                Console.WriteLine($"x={x1}, or x={x2}");
            }
            else
            {
                Console.WriteLine("Equations has no true roots");
            }


        }

    }
}