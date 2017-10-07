using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DoesListHaveCycle
    {
        public static bool IsCycle(LinkedListNode<int> firstNode)
        {
            var slowRunner = firstNode;
            var fastRunner = firstNode;
            // Until we hit the end of the list
            while (fastRunner != null || fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;
                // Case: fastRunner is about to "lap" slowRunner
                if (slowRunner == fastRunner)
                {
                    return true;
                }
            }
            // Case: fastRunner hit the end of the list
            return false;
        }
    }
}
