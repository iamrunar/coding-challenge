namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;
using solutions.Models;

/// <summary>
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/// Input: nums = [-10,-3,0,5,9] Output: [0,-3,9,-10,null,5] Explanation: [0,-10,5,null,-3,null,9] is also accepted:
/// Input: nums = [1,3] Output: [3,1] Explanation: [1,null,3] and[3, 1] are both height-balanced BSTs.
/// Constraints: 1 <= nums.length <= 104 -104 <= nums[i] <= 104 nums is sorted in a strictly increasing order.
/// https://leetcode.com/explore/featured/card/top-interview-questions-easy/94/trees/631/
/// </summary>
public class SortedArrayToBSTTest
{
    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3 }, new int[] { 1, int.MinValue, 3 })]
    [InlineData(new int[] { -10, -3, 0, 5, 9 }, new int[] { 0, -10, 5, int.MinValue, -3, int.MinValue, 9 })]
    public void Set103059_R03910null5(int[] nums, int[] expected)
    {
        new SortedArrayToBSTSolver()
            .SortedArrayToBST(nums)
            .VisitTreeNode(n => n)
            .Select(x => x == null ? int.MinValue : x.val)
            .ShouldBe(expected);
    }

}
