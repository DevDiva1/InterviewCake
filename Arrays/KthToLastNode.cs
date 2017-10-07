using System;

namespace Arrays
{
    class KthToLastNode
    {
        public static LinkedListNode FindKthToLastNode(LinkedListNode root, int kthLastNode)
        {
            if (root == null)
            {
                throw new ArgumentNullException();
            }
            if (kthLastNode == 1)
            {
                return root;
            }

            var length = 1;
            LinkedListNode traverse = root;
            while (traverse.Next != null)
            {
                length++;
                traverse = traverse.Next;
            }
            traverse = root;
            for (int i = 0; i < length - kthLastNode; i++)
            {
                traverse = traverse.Next;
            }
            return traverse;
        }
        
    }
    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            this.Value = value;
        }
    }
}
