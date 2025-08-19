using System;
using Fundamentals.LeetCode;

//Prompt to run: "dotnet run"

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode n = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            Console.WriteLine(ListNode.KValFromEnd(n, 4));
            Console.WriteLine(string.Join(", ", ListNode.ListToArray(n)));
        }
    }
}
