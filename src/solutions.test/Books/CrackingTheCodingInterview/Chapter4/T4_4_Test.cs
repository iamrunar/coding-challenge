using Shouldly;
using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_4;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_4;

public class T4_4_Test
{
    [Theory]
    [InlineData(new[] { 1 }, true)]
    [InlineData(new[] { 1, 2 }, true)]
    [InlineData(new[] { 1, 2, 3 }, true)]
    [InlineData(new[] { 1, 2, 3, 4, -1, -1, -1, 8, -1, -1, -1, -1, -1, -1, 15 }, false)]
    public void GetSet(int[] input, bool expected)
    {
        new BalancedChecker()
            .IsBalanced(input.MakeSimpleBinaryTree(-1))
            .ShouldBe(expected);
    }
}