namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;
using solutions.Models;

/// <summary>
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
public class ReverseLinkedListTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void Set112_R12_2(int[] nums, int[] expectedNums)
    {
        new ReverseLinkedListRecursionSolver()
            .ReverseList(nums.ToLinkedList())
            .ToArray()
            .ShouldBe(expectedNums);

        new ReverseLinkedListValuesLinearSolver()
            .ReverseList(nums.ToLinkedList())
            .ToArray()
            .ShouldBe(expectedNums);
    }
}
