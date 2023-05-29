using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_4_Test
    {
        [Theory]
        [InlineData(new []{3,2}, 5, new []{3,2})]
        [InlineData(new []{3,2,5}, 5, new []{3,2,5})]
        [InlineData(new []{8,10}, 5, new []{8,10})]
        [InlineData(new []{5, 8, 10}, 5, new []{5, 8, 10})]
        [InlineData(new []{8, 5, 10}, 5, new []{5, 8, 10})]
        [InlineData(new []{8, 5, 10}, 8, new []{5, 8, 10})]
        [InlineData(new []{8, 5, 8, 10}, 8, new []{5, 8, 8, 10})]
        [InlineData(new []{8, 5, 8, 10}, 9, new []{8, 5, 8, 10})]
        [InlineData(new []{3, 5, 8, 5}, 5, new []{3, 5, 5, 8})]
        [InlineData(new []{3,5,8,5,10,2,1}, 5, new []{3,2,1,5,5,8,10})]
        public void GetSet(int[] input, int x, int[] expected)
        {
            new C2Lists_T2_4_Partition()
                .Partition(input.ToLinkedList<int>(), x)
                .ToArray()
                .ShouldBe(expected);
        }

        [Theory]
        [InlineData(new []{3,2}, 5, new []{2,3})]
        [InlineData(new []{3,2,5}, 5, new []{2,3,5})]
        [InlineData(new []{8,10}, 5, new []{8,10})]
        [InlineData(new []{5, 8, 10}, 5, new []{5, 8, 10})]
        [InlineData(new []{8, 5, 10}, 5, new []{ 8, 5, 10})]
        [InlineData(new []{8, 5, 10}, 8, new []{5, 8, 10})]
        [InlineData(new []{8, 5, 8, 10}, 8, new []{5, 8, 8, 10})]
        [InlineData(new []{8, 5, 8, 10}, 9, new []{8, 5, 8, 10})]
        [InlineData(new []{3, 5, 8, 5}, 5, new []{3, 5, 8, 5})]
        [InlineData(new []{3,5,8,5,10,2,1}, 5, new []{1,2,3,5,8,5,10})]
        public void GetSet2(int[] input, int x, int[] expected)
        {
            //Буквальная реализация. Слева -- меньшие числа, справа -- большие или равные.
            new C2Lists_T2_4_Partition()
                .Partition2(input.ToLinkedList<int>(), x)
                .ToArray()
                .ShouldBe(expected);
        }
    }
}
