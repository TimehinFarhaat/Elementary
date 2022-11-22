using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result4
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    public static string isBalanced (string s)
    {
        var map = new Dictionary<char, char>
        {
            ['{'] = '}',
            ['('] = ')',
            ['['] = ']',
        };
        var tokens = new Stack<char>();
        foreach (var c in s)
        {
            if (map.ContainsKey(c))
            {
                tokens.Push(c);
                continue;
            }

            if (tokens.Any() && map[tokens.Peek()] == c)
            {
                tokens.Pop();
                continue;
            }

            return "NO";
        }

        return !tokens.Any() ? "YES" : "NO";
    }

}

class Solution4
{
    public static void Main4 (string[] args)
    {
        TextWriter textWriter = Console.Out; // new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result4.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}