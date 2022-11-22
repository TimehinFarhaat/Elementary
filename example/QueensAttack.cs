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

class Result3
{
    private static bool IsPointOnBoard(int n, Tuple<int, int> point) => point.Item1 >= 0 && point.Item1 < n && point.Item2 >= 0 && point.Item2 < n;

    /*
     * Complete the 'queensAttack' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER r_q
     *  4. INTEGER c_q
     *  5. 2D_INTEGER_ARRAY obstacles
     */

    public static int queensAttack (int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        var uniqueObstacles = new HashSet<Tuple<int, int>>();
        foreach (var obstacle in obstacles)
        {
            uniqueObstacles.Add(new Tuple<int, int>(obstacle[0] - 1, obstacle[1] - 1));
        }

        // the queen can move in 8 directions as long as the board still has space and there are no obstacles
        var count = 0;
        r_q--;
        c_q--;
        var m = Math.Max(r_q, c_q);
        m = Math.Max(m, n - r_q);
        m = Math.Max(m, n - c_q);

        var checkUp = true;
        var checkUpRight = true;
        var checkRight = true;
        var checkDownRight = true;
        var checkDown = true;
        var checkDownLeft = true;
        var checkLeft = true;
        var checkUpLeft = true;
        
        for (var i = 1; i <= m; i++)
        {
            var up = new Tuple<int, int>(r_q - i, c_q);
            var upRight = new Tuple<int, int>(r_q - i, c_q + i);
            var right = new Tuple<int, int>(r_q, c_q + i);
            var downRight = new Tuple<int, int>(r_q + i, c_q + i);
            var down = new Tuple<int, int>(r_q + i, c_q);
            var downLeft = new Tuple<int, int>(r_q + i, c_q - i);
            var left = new Tuple<int, int>(r_q, c_q - i);
            var upLeft = new Tuple<int, int>(r_q - i, c_q - i);

            // no point going any further
            if (!checkUp && !checkUpRight && !checkRight && !checkDownRight && !checkDown && !checkDownLeft && !checkLeft && !checkUpLeft)
            {
                break;
            }

            
            if (checkUp && IsPointOnBoard(n, up) && !uniqueObstacles.Contains(up))
            {
                count++;
            }
            else
            {
                checkUp = false;
            }
            
            if (checkUpRight && IsPointOnBoard(n, upRight) && !uniqueObstacles.Contains(upRight))
            {
                count++;
            }
            else
            {
                checkUpRight = false;
            }
            
            if (checkRight && IsPointOnBoard(n, right) && !uniqueObstacles.Contains(right))
            {
                count++;
            }
            else
            {
                checkRight = false;
            }
            
            if (checkDownRight && IsPointOnBoard(n, downRight) && !uniqueObstacles.Contains(downRight))
            {
                count++;
            }
            else
            {
                checkDownRight = false;
            }
            
            if (checkDown && IsPointOnBoard(n, down) && !uniqueObstacles.Contains(down))
            {
                count++;
            }
            else
            {
                checkDown = false;
            }

            if (checkDownLeft && IsPointOnBoard(n, downLeft) && !uniqueObstacles.Contains(downLeft))
            {
                count++;
            }
            else
            {
                checkDownLeft = false;
            }

            if (checkLeft && IsPointOnBoard(n, left) && !uniqueObstacles.Contains(left))
            {
                count++;
            }
            else
            {
                checkLeft = false;
            }

            if (checkUpLeft && IsPointOnBoard(n, upLeft) && !uniqueObstacles.Contains(upLeft))
            {
                count++;
            }
            else
            {
                checkUpLeft = false;
            }
        }

        return count;
    }

}

class Solution3
{
    public static void Main3 (string[] args)
    {
        TextWriter textWriter = Console.Out;

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r_q = Convert.ToInt32(secondMultipleInput[0]);

        int c_q = Convert.ToInt32(secondMultipleInput[1]);

        List<List<int>> obstacles = new List<List<int>>();

        for (int i = 0; i < k; i++)
        {
            obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
        }

        int result = Result3.queensAttack(n, k, r_q, c_q, obstacles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}