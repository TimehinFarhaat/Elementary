using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Collection_and_Generics
{
    class Program
    {

        public static void Main()
        {


            ClassWork.Question3();
           


































            //  ClassWork.Question4();
            //Common< Person>  s=new Common<Person>();
            //Person p=new Person("name");
            //Console.WriteLine(s.GetNameToUpper(p));
            // Palindrome();
            //ClassWork.Question2();
            //  ClassWork.Question3();
        }


        public static void Palindrome ()
        {
             Hashtable table=new Hashtable();
             string text = "babade";
             foreach (var c in text)
             {
                 if (table.ContainsKey(c))
                 {
                     table[c] = (int)table[c] + 1;
                 }
                 else
                 {
                     table[c] =  1;
                 }
             }

             int max = 0;
             bool isvalid = true;
             foreach (DictionaryEntry entry in table)
             {
                 if ((int)entry.Value % 2 != 0  )
                 {
                     max++;
                     if (max > 1)
                     {
                         isvalid = false;
                         break;
                     }
                 }
             }
             Console.WriteLine(isvalid?$"It can form palindrome":$"It cannot form a palindrome");
        }




        public static void Example()
        {
            ArrayList arrayList=new ArrayList()
            {"what",
                23,
                0
            };

            arrayList.Add("d");
            foreach (var item in arrayList)
            {
                Console.WriteLine();
            }
        }
        public static void Main2()
        {
        }


    }

}
       

