using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question11
    {
        static void Main()
        {
            Console.Write(" 1=arrange digits in reversed order \n" +
                          " 2=calculate average of a give sequence \n" +
                          " 3 =solve linear equation a* b+x \n" +
                          "Enter choice:  ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Reverse();
            }
            else if (choice == 2)
            {
                Average();
            }
            else
            {
                Equation();
            }
        }




        static void Reverse()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum = num % 10;
                int d = num / 10;
                num = d;
                Console.Write(sum);
            }
        }



        static void Average()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int d = 0;
            while (num > 0)
            {
                Console.Write("Enter numbers: ");
                int num1 = int.Parse(Console.ReadLine());
                num += num; 
                d = num;
            }
            Console.WriteLine(d/num);
        }





        static void Equation()
        {

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a * x) + b);
        }





    }
}
