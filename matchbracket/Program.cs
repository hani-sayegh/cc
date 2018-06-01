using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Linq;

class Solution
{

    static void expressionBalanced(string expression)
    {

        var s = new Stack<char>();
        foreach (var c in expression)
        {
            var tmp = new Dictionary<char, char>();
            tmp.Add('}', '{');
            tmp.Add(']', '[');
            tmp.Add(')', '(');

            if (tmp.ContainsKey(c))
            {
                if (s.Count != 0 && s.Pop() == tmp[c])
                {
                    continue;
                }
                System.Console.WriteLine("NO");
                return;
            }

            s.Push(c);

        }

        var output = "YES";
        if (s.Count != 0)
            output = "NO";
            
        System.Console.WriteLine(output);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++)
        {
            string expression = Console.ReadLine();
            expressionBalanced(expression);
        }

    }
}
