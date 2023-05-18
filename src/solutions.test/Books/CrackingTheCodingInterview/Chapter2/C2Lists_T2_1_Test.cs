using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_1_Test
    {
        [Theory]
        [InlineData(new[] { 1,2,1 }, new[] { 1,2 })]
        public void GetSet(int[] input, int[] expected)
        {
            new C2Lists_T2_1_RemoveDuplicates()
                .RemoveDuplicates(input.ToLinkedList())
                .ToArray()
                .ShouldBe(expected);
        }
    }
}
