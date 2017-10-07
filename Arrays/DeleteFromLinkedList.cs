using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
        }

        public static void main()
        {
            LinkedList a = new LinkedList(1);
            LinkedList b = new LinkedList(2);
            LinkedList c = new LinkedList(3);

            DeleteLinkedListNode.DeleteNode(a);
        }
    }

    public class DeleteLinkedListNode
    {
        public static void DeleteNode(LinkedList b)
        {
            var nextNode = b.next;
            if (nextNode != null)
            {
                b.value = nextNode.value;
                b.next = nextNode.next;
            }
            //Deleting last node or linkedList having only 1 node will cause & needs to be carefully handled.
            else
            {
                throw new InvalidOperationException("Can't delete the last node with this method!");
            }
        }
    }
    
}
