using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Question3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Englishname());
            
        }


         public static string Englishname()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int mod = num % 10;
            string a=" ";
            switch (mod)
            {
                case 0:
                  a=  "Zero";
                    break;
                case 1:
                     a ="One";
                    break;
                case 2:
                    a = "Two";
                    break;
                case 3:
                    a = "Three";
                    break;
                case 4:
                     a= "Four";
                    break;
                case 5:
                    a= "Five";
                    break;
                case 6:
                    a= "Six";
                    break;
                case 7:
                    a="Seven";
                    break;
                case 8:
                    a="Eight";
                    break;
                case 9:
                   a = "Nine";
                    break;
            }
            return a;
        }
    }
}
