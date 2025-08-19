using System;
using Fundamentals.LeetCode;

//Prompt to run: "dotnet run"

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode n = new ListNode(1, null);
            n.next = new ListNode(2, null);
            n = ListNode.InsertToList(n, 5);
            Console.WriteLine(string.Join(", ", ListNode.ListToArray(n))); 
            n = ListNode.InsertToEndOfList(n, 9);
            Console.WriteLine(string.Join(", ", ListNode.ListToArray(n))); 
        }
    }
}
