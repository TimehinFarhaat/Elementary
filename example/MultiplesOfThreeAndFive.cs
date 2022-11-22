using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution2
{
    static void Main2 (String[] args)
    {   
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            n -= 1; // greatest integer below n
            var n3 = n  / 3L;
            var n5 = n  / 5L;
            var n15 = n / 15L;

            var s3 = (3 * n3    * (1 + n3))  / 2;
            var s5 = (5 * n5 * (1 + n5)) / 2;
            var s15 = (15 * n15 * (1 + n15)) / 2;

            Console.WriteLine(s3 + s5 - s15);
        }
    }
}