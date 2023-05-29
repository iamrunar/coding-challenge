using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_5_Sum
    {
        public ListNode Sum(ListNode first, ListNode second)
        {
            ListNode p3 = null, h3 = null, p1 = first, p2 = second;
            bool addon = false;
            while (p1 != null || p2 != null || addon)
            {
                var n1 = p1?.val ?? 0;
                var n2 = p2?.val ?? 0;
                var carry = addon ? 1 : 0;
                var sumOfNumbers = n1 + n2 + carry;
                addon = sumOfNumbers > 9;

                var newP3Node = new ListNode(sumOfNumbers % 10);
                if (p3 != null) p3.next = newP3Node;

                p3 = newP3Node;
                if (h3 == null) h3 = p3;

                p1 = p1?.next;
                p2 = p2?.next;
            }
            return h3;
        }
    }
}
