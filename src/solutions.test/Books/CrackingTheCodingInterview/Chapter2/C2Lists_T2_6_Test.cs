using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_6_Test
    {
        [Theory]
        [InlineData(new[] { 1 }, true)]
        [InlineData(new[] { 1,1 }, true)]
        [InlineData(new[] { 1,2 }, false)]
        [InlineData(new[] { 1,2,1 }, true)]
        [InlineData(new[] { 1,2,2,1 }, true)]
        public void GetSet(int[] input, bool expected)
        {
            new C2Lists_T2_6_IsPolyndrom()
                .IsPolyndrom(input.ToLinkedList<int>())
                .ShouldBe(expected);
            new C2Lists_T2_6_IsPolyndrom()
                .IsPolyndrom2(input.ToLinkedList<int>())
                .ShouldBe(expected);
        }
    }
}
