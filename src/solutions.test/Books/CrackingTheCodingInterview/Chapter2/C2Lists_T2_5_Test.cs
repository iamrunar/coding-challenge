using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_5_Test
    {
        [Theory]
        [InlineData(new[] { 7,1,6 }, new[] { 5,9,2 }, new int[]{2,1,9})]
        [InlineData(new[] { 7,1,6 }, new[] { 6 }, new int[]{3,2,6})]
        [InlineData(new[] { 5 }, new[] { 7,1,6  }, new int[]{2,2,6})]
        [InlineData(new[] { 1 }, new[] { 9,9,9  }, new int[]{0,0,0,1})]
        public void GetSet(int[] first, int[] second, int[] expected)
        {
            new C2Lists_T2_5_Sum()
                .Sum(first.ToLinkedList(), second.ToLinkedList())
                .ToArray()
                .ShouldBe(expected);
        }
    }
}
