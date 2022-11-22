using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;


namespace Array
{
    class Number11
    {
        public static void Answers ()
        {
            //int i = 0;
            //while (i <= 100)
            //{
            // 
            //   
            //  i += 2;
            //    
            //    Console.WriteLine(i);
            //}


            //int i = 0;
            //while (i <= 100)
            //{
            //    i += 7;

            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //for (Console.WriteLine("This is the first time"); i < 3; Console.WriteLine("Farhaat"))
            //{
            //   Console.WriteLine("Greetings from loop");
            //    i++;
            //}



            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= num; i++)  Console.WriteLine(i);


            //Console.Write("Enter multiple: ");
            //int multiple1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the limit: ");
            //int time1 = int.Parse(Console.ReadLine());
            //int num = 0;
            //for (int i = 0; i <= time1; i++)
            //{
            //    num += multiple1;
            //    Console.WriteLine(num);
            //}



            //Console.Write("Enter multiple: ");
            //int multiple = int.Parse(Console.ReadLine());
            //Console.Write("Enter the limit: ");
            //int time = int.Parse(Console.ReadLine());
            //int a = 0;
            //for (int i = 1; i <= time; i++)
            //{
            //    if (a % multiple == 0)
            //    {
            //        Console.WriteLine(a);
            //        a++;
            //    }
            //} 


            //int i = 0;
            //while (true)
            //{
            //    int g = 0;
            //}



            //while (true)
            //{
            //    int g = 0;
            //}
            //Console.WriteLine(i);




            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //int i = 0;
            //int sum = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine($"The sum of the numbers is {sum}");



            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int j = 0; j <= num; j++)
            //{
            //    Console.WriteLine(j);
            //    sum += j;
            //}
            //Console.WriteLine($"The sum of the numbers is {sum}");


            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);



            // Question 1
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i <= 12)
            //{
            //    int sum = 1;
            //    sum = num * i;
            //    Console.WriteLine($"{num} * {i} = {sum}");
            //    i++;
            //}


            //Question 2
            //Console.Write("Enter the number: ");
            //int nom1 = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= nom1; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}




            //Question 3
            //Console.Write("Enter the number: ");
            //int nom = int.Parse(Console.ReadLine());
            //for (int i = 1; i <=nom; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}



            //Question4
            //Console.Write("Enter the number: ");
            //int nom = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= nom; i++)
            //{
            //    int space = nom - i;
            //    for (int j = 1; j <= space/2 ; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("x");
            //    }
            //    Console.WriteLine();
            //}


            //question 5
            Console.Write("Enter a number: ");
            int n1m = int.Parse(Console.ReadLine());
            int a = -1;
            int b = 1;
            int r = 0;
            int c = 0;
            do
            {
                c = a + b;
                Console.Write(c + ", ");
                a = b;
                b = c;
                r++;
            } while (r < n1m);























































































































































        }

    }
}