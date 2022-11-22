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

class Result1
{
    private static int GetWeight(char c) => c - 'a' + 1;

    /*
     * Complete the 'weightedUniformStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER_ARRAY queries
     */

    public static List<string> weightedUniformStrings (string s, List<int> queries)
    {
        // build weight set
        var weights = new HashSet<int>();
        var currentChar = s[0];
        var currentWeight = GetWeight(currentChar);
        weights.Add(currentWeight);

        for (var i = 1; i < s.Length; i++)
        {
            var c = s[i];

            if (currentChar == c)
            {
                currentWeight += GetWeight(c);
            }
            else
            {
                currentWeight = GetWeight(c);
                currentChar = c;
            }
            weights.Add(currentWeight);
        }

       // run queries
        var results = new List<string>();
        foreach (var query in queries)
        {
            if (weights.Contains(query))
            {
                results.Add("Yes");
            }
            else
            {
                results.Add("No");
            }
        }

        return results;
    }
}

class Solution1
{
    public static void Main1 (string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> queries = new List<int>();

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<string> result = Result1.weightedUniformStrings(s, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}