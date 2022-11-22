using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question2
    {
        static void Main()
        {

            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num3 = int.Parse(Console.ReadLine());
            int max = Getmax(num1,num2);
            Console.WriteLine(Getmax(max, num3));


        }


        static int Getmax(int a,int b)
        {

            int big;
            if (a>b)
            {
                big = a;
            }
            else
            {
                big = b;
            }
            return big;
        }











        
    }
}
