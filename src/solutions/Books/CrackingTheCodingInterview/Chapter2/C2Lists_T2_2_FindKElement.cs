using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_2_FindKElement
    {
        public int FindKElement(ListNode head, int k)
        {
            ListNode current = head, previous = head;
            var delta = 0;
            while (current.next != null)
            {
                current = current.next;

                if (delta == k) previous = previous.next;
                else delta++;
            }

            return previous.val;
        }
        public int FindKElement3(ListNode head, int k)
        {
            ListNode last = head;
            ListNode knode = head;

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

        public int FindKElement2(ListNode head, int k)
        {
            return FindKElement2Internal(head, k, head).val;

            ListNode FindKElement2Internal(ListNode current, int ck, ListNode previous)
            {
                if (current.next == null) return previous;

                return FindKElement2Internal(current.next, ck - 1, ck <= 0 ? previous.next : previous);
            }
        }
    }
}
