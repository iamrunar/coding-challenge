namespace solutions.Models;

public class LinkedListNode2
{
    public LinkedListNode2 next;
    public int val;
    public int key;

    public LinkedListNode2(int val, LinkedListNode2 next = null)
    {
        key = key;
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString();
    }
}

public static class LinkedListNodeHelper
{
    public static LinkedListNode2[] ToLinkedListArray(this int[][] lists)
    {
        return lists.Select(n => n.ToLinkedList()).ToArray();
    }

    public static LinkedListNode2 ToLinkedList(this int[] nums)
    {
        LinkedListNode2 head = null;
        LinkedListNode2 lastNode = null;
        foreach (var n in nums)
        {
            var node = new LinkedListNode2(n);
            if (head == null)
            {
                head = node;
            }
            if (lastNode != null)
            {
                lastNode.next = node;
            }
            lastNode = node;
        }
        return head;
    }

    public static int[] ToArray(this LinkedListNode2 head)
    {
        List<int> result = new List<int>();
        var c = head;
        while (c != null)
        {
            result.Add(c.val);
            c = c.next;
        }
        return result.ToArray();
    }
}