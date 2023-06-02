using Shouldly;
using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_5;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_5;

public class T4_5_Test
{
    [Theory]
    [InlineData(new[] { 1 }, true)]
    [InlineData(new[] { 1, 2 }, true)]
    [InlineData(new[] { 2, 1 }, false)]
    [InlineData(new[] { 1, 2, 3 }, true)]
    [InlineData(new[] { 1, 3, 2 }, false)]
    [InlineData(new[] { 1, 2, 4, 5, 3, 6, 7 }, false)]
    public void GetSet(int[] input, bool expected)
    {
        new CheckBinaryTreeSearch()
            .Check(input.MakeSimpleBinaryTree(-1))
            .ShouldBe(expected);
    }
}