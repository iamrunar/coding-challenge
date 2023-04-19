namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;

/// <summary>
/// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/883/
/// </summary>
public class PalindromeSolverTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    public void SetArrays_RT(string input, bool expected)
    {
        new PalindromeSolver()
            .IsPalindrome(input)
            .ShouldBe(expected);
    }
}