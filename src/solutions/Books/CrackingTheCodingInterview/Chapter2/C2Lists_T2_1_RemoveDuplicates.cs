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

    public class C2Lists_T2_2_FindKElement
    {
        public int FindKElement(LinkedListNode2 head, int k)
        {
            LinkedListNode2 current = head, previous = head;
            var delta = 0;
            while (current.next != null)
            {
                current = current.next;

                if (delta == k) previous = previous.next;
                else delta++;
            }

            return previous.val;
        }
        public int FindKElement3(LinkedListNode2 head, int k)
        {
            LinkedListNode2 last = head;
            LinkedListNode2 knode = head;

            for (int i = 0; i < k; i++)
            {
                if (last == null) throw new InvalidOperationException("K-element not found");
                last = last.next;
            }

            while (last.next != null)
            {
                last = last.next;
                knode = knode.next;
            }

            return knode.val;
        }

        public int FindKElement2(LinkedListNode2 head, int k)
        {
            return FindKElement2Internal(head, k, head).val;

            LinkedListNode2 FindKElement2Internal(LinkedListNode2 current, int ck, LinkedListNode2 previous)
            {
                if (current.next == null) return previous;

                return FindKElement2Internal(current.next, ck - 1, ck <= 0 ? previous.next : previous);
            }
        }
    }
}
