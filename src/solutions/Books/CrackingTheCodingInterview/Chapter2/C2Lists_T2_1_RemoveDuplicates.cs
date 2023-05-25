using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_1_RemoveDuplicates
    {
        public LinkedListNode2 RemoveDuplicates(LinkedListNode2 head)
        {
            //cpu O(n)
            //mem O(n)
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

        public LinkedListNode2 RemoveDuplicates2(LinkedListNode2 head)
        {
            //cpu O(n^2)
            //mem O(1)
            LinkedListNode2 current = head;
            while (current != null)
            {
                LinkedListNode2 runner = current;
                while (runner.next!=null)
                {
                    if (runner.next.val == current.val)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }

                current = current.next;
            }
            return head;
        }
    }
}
