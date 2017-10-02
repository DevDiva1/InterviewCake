using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace In_Place_Algorithms
{
    class ReverseLinkedList
    {
        static void Main(string[] args)
        {
        }

        public class LinkedListNode
        {
            public int Value { get; set; }
            public LinkedListNode Next { get; set; }

            public LinkedListNode(int value)
            {
                Value = value;
            }
        }

        public LinkedListNode Reverse(LinkedListNode root)
        {
            var current = root;
            LinkedListNode previous = null;
            LinkedListNode nextNode = null;

            while (current != null)
            {
                // Copy a pointer to the next element
                // before we overwrite current.Next
                nextNode = current.Next;

                // Reverse the 'Next' pointer
                current.Next = previous;

                // Step forward in the list
                previous = current;
                current = nextNode;
            }
            return previous;
        }

    }
}
