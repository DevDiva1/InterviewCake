using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ImplementQueueWith2Stacks
    {
        private Stack<int> _inStack = new Stack<int>();
        private Stack<int> _outStack = new Stack<int>();

        public void Enqueue(int item)
        {
            _inStack.Push(item);
        }

        public int Dequeue()
        {
            if (_outStack.Count == 0)
            {
                //Move items from instack to outStack , reversing the order
                while (_inStack.Count > 0)
                {
                    int newestInStackItem = _inStack.Pop();
                    _outStack.Push(newestInStackItem);
                }
            }
            return _outStack.Pop();
        }
    }
}
