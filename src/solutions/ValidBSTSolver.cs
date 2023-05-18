using solutions.Models;

namespace solutions.easy;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class ValidBSTSolver
{
    int? _prevValue;
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) return true;

        if (!IsValidBST(root.left)) return false;

        if (_prevValue == null) _prevValue = root.val;
        else if (_prevValue >= root.val) return false;

        return IsValidBST(root.right);
    }
}