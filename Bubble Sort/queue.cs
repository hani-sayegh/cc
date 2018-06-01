using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var inbox = new Stack<int>();
        var outbox = new Stack<int>();
        while (n-- != 0)
        {
            var tmp = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            switch (tmp[0])
            {
                case 1:
                    inbox.Push(tmp[1]);
                    break;
                case 2:
                    if (outbox.Count == 0)
                    {
                        while (inbox.Count != 0)
                        {
                            outbox.Push(inbox.Pop());
                        }
                    }
                    if (outbox.Count != 0)
                        outbox.Pop();
                    break;
                case 3:
                    if (outbox.Count == 0)
                    {
                        while (inbox.Count != 0)
                        {
                            outbox.Push(inbox.Pop());
                        }
                    }
                    if (outbox.Count != 0)
                        System.Console.WriteLine(outbox.Peek());
                    break;
            }
        }
    }
}