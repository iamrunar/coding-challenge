using System.Security.Cryptography;
using System.Xml.Linq;

namespace solutions.easy;

public class SquaresOfSortedArraySolver
{
    //nums in non-decreasing order
    public int[] SortedSquares(int[] nums)
    {
        int[] values = new int[nums.Length];
        for (int i = nums.Length-1, left = 0, right = nums.Length-1; i>=0;i--)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                values[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                values[i] = nums[right] * nums[right];
                right--;
            }
        }

        return values;
    }

}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class TreeNodeConverter
{
    public static IEnumerable<T> VisitTreeNode<T>(this TreeNode head, Func<TreeNode?, T> selector)
    {
        List<T> arrays = new List<T>();
        VisitTreeNode(head, t => arrays.Add(selector(t)));
        return arrays;
    }
    public static void VisitTreeNode(this TreeNode head, Action<TreeNode?> visit)
    {
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(head);

        while (nodes.Count>0)
        {
            var currentNode = nodes.Dequeue();
            if (currentNode != null)
            {
                if (visited.Contains(currentNode))
                {
                    continue;
                }
                visited.Add(currentNode);
            }

            visit(currentNode);
            if (currentNode!=null && (currentNode.left!=null || currentNode.right!= null))
            {
                nodes.Enqueue(currentNode.left);
                nodes.Enqueue(currentNode.right);
            }
        }
    }
}

