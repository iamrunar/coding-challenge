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

    public class C2Lists_T2_3_DeleteMiddleNode
    {
        public void DeleteMiddleNode(ref LinkedListNode2 head)
        {
            LinkedListNode2 previousMiddleNode = GetPreviousMiddleNode(head);
            if (previousMiddleNode == null)
            {
                head = head.next;
                return ;
            }
            RemoveNextNode(previousMiddleNode);

            LinkedListNode2 GetPreviousMiddleNode(LinkedListNode2 h)
            {
                var runner = h;
                var middle = h;
                LinkedListNode2 previous = null;
                while (runner.next!=null && runner.next.next!=null)
                {
                    previous = middle;

                    runner = runner.next.next;
                    middle = middle.next;
                }

                return previous;
            }

            void RemoveNextNode(LinkedListNode2 previous)
            {
                previous.next = previous.next.next;
            }
        }
    }

    public class C2Lists_T2_4_Partition
    {
        public LinkedListNode2 Partition(LinkedListNode2 head, int x)
        {
            LinkedListNode2 hLittle = null,pLittle = null,
                            hGreater = null,pGreater = null,
                            hEq = null,pEq = null,
                            current=head, next;
            while (current!=null)
            {
                next = current.next;
                if (current.val < x)
                {
                    if (hLittle==null)
                    {
                        hLittle = pLittle = current;
                    }
                    else
                    {
                        pLittle.next = current;
                        pLittle = current;
                    }
                }
                else if (current.val > x)
                {
                    if (hGreater==null)
                    {
                        hGreater = pGreater = current;
                    }
                    else
                    {
                        pGreater.next = current;
                        pGreater = current;
                    }
                }
                else //n.val == x
                {
                    if (hEq==null)
                    {
                        hEq = pEq = current;
                    }
                    else
                    {
                        pEq.next = current;
                        pEq = current;
                    }
                }
                current = next;
            }
            var h = hLittle ?? hEq ?? hGreater;
            if (pLittle !=null)
            {
                pLittle.next = hEq ?? hGreater;
            }
            if (pEq!=null)
            {
                pEq.next = hGreater;
            }
            if (pGreater!=null)
            {
                pGreater.next = null;
            }
            return hLittle ?? hEq ?? hGreater;
        }

        public LinkedListNode2 Partition2(LinkedListNode2 head, int x)
        {
            LinkedListNode2 h=head,t=head, n = head, next;

            while (n!=null)
            {
                next = n.next;

                if (n.val<x)
                {
                    if (h!=n)
                        n.next = h;
                    h=n;
                }
                else if (n.val>=x)
                {
                    if (t!=n)
                    t.next = n;
                    t = n;
                }

                n = next;
            }
            t.next = null;
            return h ;
        }
    }
}
