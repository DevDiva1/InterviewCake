using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //You want to be able to access the largest element in a stack.
    class LargestStack
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();

        public void Push(int value)
        {
            stack.Push(value);
            if (maxStack.Count == 0 || maxStack.Peek() < value)
            {
                maxStack.Push(value);
            }
        }

        public int Pop()
        {
            int value = stack.Pop();
            if (value == maxStack.Peek())
            {
                maxStack.Pop();
            }
            return value;
        }

        public int GetMax()
        {
            if (maxStack.Count > 0)
                return maxStack.Peek();
            throw new InvalidOperationException("Missing Push operation before invoking GetMax()");
        }
    }
}
