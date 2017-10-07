using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arrays;

namespace Arrays
{
    class KthToLastNode
    {
        public static MainClass.LinkedListNode FindKthToLastNode(MainClass.LinkedListNode root, int kthLastNode)
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
            MainClass.LinkedListNode traverse = root;
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
}
