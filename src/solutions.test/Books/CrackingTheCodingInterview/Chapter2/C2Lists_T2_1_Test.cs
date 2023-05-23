using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_1_Test
    {
        [Theory]
        [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 2, 1, 1, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 1, 2, 2, 2, 1, 3 }, new[] { 1, 2, 3 })]
        public void GetSet(int[] input, int[] expected)
        {
            new C2Lists_T2_1_RemoveDuplicates()
                .RemoveDuplicates(input.ToLinkedList())
                .ToArray()
                .ShouldBe(expected);
            new C2Lists_T2_1_RemoveDuplicates()
                .RemoveDuplicates2(input.ToLinkedList())
                .ToArray()
                .ShouldBe(expected);
        }
    }

    public class C2Lists_T2_2_Test
    {
        [Theory]
        [InlineData(new[] { 11, 7, 5, 3 }, 1, 5)]
        [InlineData(new[] { 11, 7, 5, 3 }, 0, 3)]
        [InlineData(new[] { 11, 7, 5, 3 }, 3, 11)]
        public void GetSet(int[] input, int k, int expected)
        {
            new C2Lists_T2_2_FindKElement()
                .FindKElement(input.ToLinkedList(), k)
                .ShouldBe(expected);
            new C2Lists_T2_2_FindKElement()
                .FindKElement2(input.ToLinkedList(), k)
                .ShouldBe(expected);
            new C2Lists_T2_2_FindKElement()
                .FindKElement3(input.ToLinkedList(), k)
                .ShouldBe(expected);
        }
    }

    public class C2Lists_T2_3_Test
    {
        [Theory]
        [InlineData(new[] { 1,2 }, new int[]{2})]
        [InlineData(new[] { 1,2,3 }, new int[]{1,3})]
        [InlineData(new[] { 1,2,3,4 }, new int[]{1,3,4})]
        [InlineData(new[] { 1,2,3,4,5 }, new int[]{1,2,4,5})]
        [InlineData(new[] { 1,2,3,4,5,6 }, new int[]{1,2,4,5,6})]
        public void GetSet(int[] input, int[] expected)
        {
            var head = input.ToLinkedList();
            new C2Lists_T2_3_DeleteMiddleNode()
                .DeleteMiddleNode(ref head);

            head
                .ToArray()
                .ShouldBe(expected);
        }
    }

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
                .Partition(input.ToLinkedList(), x)
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
                .Partition2(input.ToLinkedList(), x)
                .ToArray()
                .ShouldBe(expected);
        }
    }
}
