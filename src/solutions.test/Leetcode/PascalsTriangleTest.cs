namespace solutions.test.Leetcode;
using Shouldly;
using solutions.easy;
using System.ComponentModel;

/// <summary>
/// Given an integer numRows, return the first numRows of Pascal's triangle.
/// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown
/// https://leetcode.com/problems/pascals-triangle
/// </summary>
public class PascalsTriangleTest
{
    [Fact]
    public void NumRowe1_R1()
    {
        var numRows = 1;
        List<List<int>> expected = new()
        {
            new() { 1 }
        };

        new PascalTriangleBuilder()
            .Generate(numRows)
            .ShouldBe(expected);
    }

    [Fact]
    public void NumRowe5_Rr1r11r121r1331r14641()
    {
        //[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        var numRows = 1;
        List<List<int>> expected = new()
        {
            new() { 1 }
        };

        new PascalTriangleBuilder()
            .Generate(numRows)
            .ShouldBe(expected);
    }
}
