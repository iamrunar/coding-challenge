namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;
using solutions.Models;

/// <summary>
/// https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class MergeKListsTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Set112_R12_2(int[][] lists, int[] expected)
    {
        new MergeKListsSolver()
            .MergeKLists(lists.ToLinkedListArray<int>())
            .ToArray()
            .ShouldBe(expected);
    }
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]{ new int[][] { new int[] { 1, 4, 5 }, new int[] { 1, 3, 4 }, new int[] { 2, 6 } }, new int[] { 1, 1, 2, 3, 4, 4, 5, 6 } },
            new object[]{ new int[][] {  }, new int[]{  } },
            new object[]{ new int[][] { new int[] { } }, new int[] { } }
        };
}
/// <summary>
/// https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class Merge2ListsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 0 }, new int[] { }, new int[] { 0 })]
    public void Set112_R12_2(int[] list1, int[] list2, int[] expected)
    {
        new MergeTwoListsSolver()
            .MergeTwoLists(list1.ToLinkedList(), list2.ToLinkedList())
            .ToArray()
            .ShouldBe(expected);
    }
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]{ new int[][] { new int[] { 1, 4, 5 }, new int[] { 1, 3, 4 }, new int[] { 2, 6 } }, new int[] { 1, 1, 2, 3, 4, 4, 5, 6 } },
            new object[]{ new int[][] {  }, new int[]{  } },
            new object[]{ new int[][] { new int[] { } }, new int[] { } }
        };
}

public class CountBitsTest
{
    [Theory]
    [InlineData("011", 2)]
    [InlineData("11", 2)]
    [InlineData("0101", 2)]
    [InlineData("101", 2)]
    [InlineData("01011001", 3)]
    [InlineData("1011001", 3)]
    [InlineData("010110011111", 5)]
    [InlineData("10110011111", 5)]
    [InlineData("0101100110111", 5)]
    [InlineData("101100110111", 5)]
    public void Set_Get(string nums, int expected)
    {
        new CountBitsSolver()
            .GetCount(nums)
            .ShouldBe(expected);
    }
}