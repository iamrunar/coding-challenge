﻿using Shouldly;
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
}
