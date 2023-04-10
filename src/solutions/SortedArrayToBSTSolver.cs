namespace solutions.easy;

/// <summary>
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/// Input: nums = [1,3] Output: [3,1] Explanation: [1,null,3] and[3, 1] are both height-balanced BSTs.
/// Input: nums = [-10,-3,0,5,9] Output: [0,-3,9,-10,null,5] Explanation: [0,-10,5,null,-3,null,9] is also accepted:
/// </summary>
public class SortedArrayToBSTSolver
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return toNode(0, nums.Length-1);

        TreeNode toNode(int l, int r)
        {
            if (l > r) { return null; }
            var mid = (r + l) / 2;
            return new TreeNode(nums[mid], toNode(l, mid - 1), toNode(mid + 1, r));
        }
    }
}

