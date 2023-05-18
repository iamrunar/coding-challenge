namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;

/// <summary>
/// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
/// Constraints:
/// 0 <= n <= 105
/// Follow up:
/// It is very easy to come up with a solution with a runtime of O(n log n). Can you do it in linear time O(n) and possibly in a single pass?
/// Can you do it without using any built-in function(i.e., like __builtin_popcount in C++)?
/// Ex:
/// n=2 
///     0 -  0 - 0
///     1 -  1 - 1
///     2 - 10 - 1
/// n=5
///     0 -   0 - 0
///     1 -   1 - 1
///     2 -  10 - 1
///     3 -  11 - 2
///     4 - 100 - 1
///     5 - 101 - 2
/// https://leetcode.com/problems/counting-bits/
/// </summary>
public class CountingBitsTest
{
    [Fact]
    public void Ne2_R011()
    {
        var n = 2;
        var expected = new int[] { 0, 1, 1 };

        new CountingBitsSolver()
            .CountBits(n)
            .ShouldBe(expected);
    }

    [Fact]
    public void Ne5_R011212()
    {
        var n = 5;
        var expected = new int[] { 0, 1, 1, 2, 1, 2 };

        new CountingBitsSolver()
            .CountBits(n)
            .ShouldBe(expected);
    }
}
