//rename to solutions.Common.Models
namespace solutions.Models;

//rename to IntTreeNode
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

//rename to IntTreeNodeConverter
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

        while (nodes.Count > 0)
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
            if (currentNode != null && (currentNode.left != null || currentNode.right != null))
            {
                nodes.Enqueue(currentNode.left);
                nodes.Enqueue(currentNode.right);
            }
        }
    }

    public static TreeNode CreateBinaryTreeByLeetcode(this int[] nums)
    {
        List<TreeNode> nodes = new List<TreeNode>();
        int pp = 0;
        var pc = pp + 1;

        nodes.Add(new TreeNode(nums[0]));
        while (pc + 1 < nums.Length)
        {
            var parent = nodes[pp];
            if (parent != null)
            {
                parent.left = nums[pc] == int.MinValue ? null : new TreeNode(nums[pc]);
                parent.right = nums[pc + 1] == int.MinValue ? null : new TreeNode(nums[pc + 1]);

                nodes.Add(parent.left);
                nodes.Add(parent.right);
            }
            pc += 2;
            pp++;
        }
        return nodes.First();
    }
}