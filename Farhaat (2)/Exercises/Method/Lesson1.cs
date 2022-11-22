using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            printName();
            
        }


        static void printName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine($"Welcome {name} ,Thank you for using our app");
            printnameType(name);
            namePrefix(name,gender);

        }


        static void printnameType(string name)
        {
         // Console.Write("Enter your name: ");
         // string name = Console.ReadLine().ToLower();
         string a = name.Substring(0, 1);
          if (a=="a" ||a=="e"||a=="i"||a=="o"||a=="u")
          {
              Console.WriteLine("Your name starts with a vowel letter");
          }
          else
          {
              Console.WriteLine("Your name starts with  a consonant letter");
          }


        }


        static void printAge()
        {
            Console.WriteLine("My age is 12");
        }


        static void namePrefix(string name, string  gender)
        {
            string newName;
            if (gender == "male")
            {
               newName=$"Mr {name}";
            }
            else
            {
                newName=$"Mrs {name}";
            }
            Console.WriteLine(newName); 
        }














    }
}
