namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;
using solutions.Models;

/// <summary>
/// https://leetcode.com/problems/validate-binary-search-tree/description/
/// </summary>
public class ValidBSTTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 3 }, true)]
    [InlineData(new int[] { 5, 1, 4, int.MinValue, int.MinValue, 3, 6 }, true)]
    public void Set103059_R03910null5(int[] nums, bool expected)
    {
        var binaryTree = nums.CreateBinaryTreeByLeetcode();
        new ValidBSTSolver()
            .IsValidBST(binaryTree)
            .ShouldBe(expected);
    }

}