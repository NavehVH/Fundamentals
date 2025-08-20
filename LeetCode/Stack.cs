using System;

namespace Fundamentals.LeetCode
{
    public class Stack
    {
        private int[] arr;
        private int top;

        private const int CAPACITY = 1000;

        public Stack()
        {
            this.arr = new int[CAPACITY];
            this.top = -1;
        }

        public bool IsEmpty()
        {
            return this.top == -1;
        }

        public void Push(int val)
        {
            if (top >= CAPACITY - 1)
                throw new InvalidOperationException("Stack is at max capacity.");
            this.top++;
            this.arr[top] = val;
        }

        public int Peek()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException("Empty Stack.");

            return this.arr[top];
        }

        public int Pop()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException("Already Empty Stack");

            this.top--;
            return this.arr[top + 1];
        }
    }
}