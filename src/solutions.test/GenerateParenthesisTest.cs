namespace solutions.test.easy;
using Shouldly;
using solutions.easy;

/// <summary>
/// https://leetcode.com/problems/generate-parentheses/
/// </summary>
public class GenerateParenthesisTest
{
    [Theory]
    [InlineData(1, new[] { "()" })]
    [InlineData(2, new[] { "()()", "(())" })]
    [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    public void Set(int n, string[] expected)
    {
        new GenerateParenthesisRecursionSolver()
            .GenerateParenthesis(n)
            .ShouldBe(expected,true);
        new GenerateParenthesisBruteforceSolver()
            .GenerateParenthesis(n)
            .ShouldBe(expected, true);
    }
}