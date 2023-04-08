namespace solutions.test.easy;
using Shouldly;
using solutions.easy;

/// <summary>
/// https://neetcode.io/practice
/// https://leetcode.com/problems/contains-duplicate/
/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
/// Example 1: Input: nums = [1,2,3,1] Output: true
/// Example 2: Input: nums = [1,2,3,4] Output: false
/// Example 3: Input: nums = [1,1,1,3,3,4,3,2,4,2] Output: true
/// Constraints: 
/// 1 <= nums.length <= 105 
/// -109 <= nums[i] <= 109
/// </summary>
public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new int[] { 1,2,3,1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Numse1231_RT(int[] nums, bool expected)
    {
        new ContainsDuplicateSolver()
            .ContainsDuplicate(nums)
            .ShouldBe(expected);
    }
}
