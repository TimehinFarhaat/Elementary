using System;
using System.ComponentModel;
using System.Text;


namespace Chapter3
{
    class Number15
    {
        public static void Answers()
        {
            //int a = 5;
            //int b = 4;
           // Console.WriteLine(a & b);
          //  Console.WriteLine(a ^ b);
           // Console.WriteLine(a<<1);

         //  string name = "ayo";
         //string  name1 =  name;
         //  StringBuilder name2=new StringBuilder();
         //  name2.Append("igun");
         //  name2.Append("Ayo");
         //  name2.Append("Tayo");
         //  Console.WriteLine(name2);
         //Console.WriteLine(name1.Equals(name));
         //Console.WriteLine(name.Contains('a'));
         // name =name.Replace('y', 'p');
         //Console.WriteLine(name);


           //string a = "school";
           ////string first = a[0].ToString().ToUpper();
           //a=a.Replace(a[0].ToString(), a[0].ToString().ToUpper());
           //a = a.Replace(a[a.Length - 1].ToString(), a[a.Length - 1].ToString().ToUpper());
           //a = a.Replace(a[1].ToString(), a[1].ToString().ToUpper());
           // Console.WriteLine(a);

            //Console.Write("Enter your full name separated by space: ");
            //string name = Console.ReadLine().ToLower();
            //char first = name[0];
            //int space = name.IndexOf(" ")+1;
            //name = name.Replace(first.ToString(), first.ToString().ToUpper());
            //name = name.Replace(name[space].ToString(), name[space].ToString().ToUpper());
            //Console.WriteLine(name);


            Console.Write("Enter name: ");
            string a = Console.ReadLine();
            int space = a.IndexOf(' '); 
            string first = a.Substring(0, 1).ToUpper();
            string surn = a.Substring(space + 1, 1).ToUpper();
             string fname = a.Substring(1, space);
            string sname = a.Substring(space + 2);
            StringBuilder Newname=new StringBuilder();
            Newname.Append(first);
            Newname.Append(fname);
            Newname.Append(surn);
            Newname.Append(sname);
            Console.WriteLine(Newname);




































        }
    }
}