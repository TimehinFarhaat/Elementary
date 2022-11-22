using System;
using System.Diagnostics.CodeAnalysis;


namespace Method
{
    class ClassTest
    {
        static void Main(string[] args)
        {
            Calculator();



            static void Calculator()
            {

                Console.Write("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the operation: ");
                string opeator = Console.ReadLine().ToLower();

                int answer;
                if (opeator == "addition" || opeator == "+" || opeator == "add")
                {
                    answer = Addition(num1, num2);
                }

                if (opeator == "subtraction" || opeator == "subtract" || opeator == "-")
                {
                    Subtraction(num1, num2);
                }

                if (opeator == "division" || opeator == "divide" || opeator == "/")
                {
                    Division(num1, num2);
                }

                if (opeator == "modulo" || opeator == "%")
                {
                    Modulo(num1, num2);
                }

                if (opeator == "multiplication" || opeator == "*")
                {
                    Multiplication(num1, num2);
                }
            }


            static int   Addition(int num1, int num2)
            {

                return  num1 + num2;
               

            }



            static void Subtraction(int num1, int num2)
            {

                if (num1 > num2)
                {
                    Console.WriteLine(num1 - num2);
                }
                else if(num2 > num1)
                {
                    Console.WriteLine(num2 - num1);
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }

            }




            static void Division(int num1, int num2)
            {

                if (num1 > num2)
                {
                    Console.WriteLine(num1 / num2);
                }
                else if(num2 > num1)
                {
                    Console.WriteLine(num2 / num1);
                }
                else
                {
                    Console.WriteLine(num1/num2);
                }

            }




            static void Modulo(int num1, int num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1 % num2);
                }
                else if(num2 > num1)
                {
                    Console.WriteLine(num2 % num1);
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }

            }



            static void Multiplication(int num1, int num2)
            {

                Console.Write(num1 * num2);
            }
        }
    }
} 