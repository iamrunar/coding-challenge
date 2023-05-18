using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_1_RemoveDuplicates
    {
        public LinkedListNode2 RemoveDuplicates(LinkedListNode2 head)
        {
            HashSet<int> keys = new HashSet<int>();

            LinkedListNode2 newHead = null, newCurrent = null;
            LinkedListNode2 current = head;
            while (current!=null)
            {
                if (!keys.Contains(current.val))
                {
                    keys.Add(current.val);
                    var node = new LinkedListNode2(current.val);
                    if (newCurrent != null)
                    {
                        newCurrent.next = node;
                    }
                    else
                    {
                        newHead = node;
                    }
                    newCurrent = node;
                }

                current = current.next;
            }
            return newHead;
        }
    }
}
