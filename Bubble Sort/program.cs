using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        var numSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    ++numSwaps;
                    var temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
System.Console.WriteLine(numSwaps);
System.Console.WriteLine("First Element:" + a[0]);
System.Console.WriteLine("Last Element: " + a.Last());
    }
}
