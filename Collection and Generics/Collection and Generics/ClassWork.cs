using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Collection_and_Generics
{
    class ClassWork
    {
        public static void Question1()
        {

        }


        public static void Question2()
        {
            Hashtable table=new Hashtable();
            int[] values = new[] { 1, 2, 3, 4 };
            foreach (var item in values)
            {
                if (table.ContainsKey(item))
                {
                    table[item] = (int)table[item] + 1;
                }
                else
                {
                    table[item] = 1;
                }
            }
            bool cont = false;
            foreach (DictionaryEntry entry in table)
            {
                if ((int)entry.Value > 1)
                {
                    cont = true;
                    break;
                }
            }
            Console.WriteLine(cont);


        }


        public static void Question3()
        {
            int max = 0;
            Hashtable hashtable = new Hashtable();
            List<int> d=new List<int>();
            List<string> n=new List<string>();
            var arr1 = new[] { "so", "as", "he" };
            var arr2 = new[] { "as", "on", "he" };
            foreach (var s in arr1)
            {
                hashtable[s] = Array.IndexOf(arr1, s);
            }
            foreach (var s in arr2)
            {
                if (hashtable.ContainsKey(s))
                {
                    hashtable[s] = (int) hashtable[s] + Array.IndexOf(arr2, s);
                    d.Add((int) hashtable[s] + Array.IndexOf(arr2, s));
                    n.Add((string) hashtable[s]);

                }
                
            }
            for (int i = 0; i < d.Count-1; i++)
            {
                for (int j = 0; j <d.Count-1; j++)
                {
                    if (d[j] <= d[j + 1])
                    {
                        Console.WriteLine(n[j]);
                        break;
                    }
                }
            }
        }


        public static void Question4()
        {
            List<int> d=new List<int>();
            List<int >y=new List<int>();
            List<int> a = new List<int>{ 1, 2,4,1,6,4,1,6 };
            Hashtable table=new Hashtable();
            foreach (var item in a)
            {
                if (table.ContainsKey(item))
                {
                    table[item]= (int) table[item] + 1;
                }
                else
                {
                    table[item] = 1;
                }
            }

            foreach (DictionaryEntry entry in table)
            {
                if ((int)entry.Value > 1)
                {
                   d.Add((int)entry.Key);
                   y.Add((int)entry.Value);
                }
            }

            for (int i = 0; i < d.Count-1; i++)
            {
                for (int j = 0; j < d.Count-1; j++)
                {
                    if (d[j] > d[j + 1])
                    {
                        int t = d[j];
                        d[j] = d[j + 1];
                        d[j + 1] = t;

                        int r = y[j];
                        y[j] = y[j + 1];
                        y[j + 1] = r;

                    }

                }
            }

            for (int i = 0; i < d.Count; i++)
            {
                Console.Write(d[i] + "," );
            }

            Console.WriteLine();

            for (int i = 0; i < d.Count; i++)
            { 
                Console.Write(y[i] + ",");
            }






        }
    }
}
