using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_6_CompressTest
{
    [Theory]
    [InlineData("aabcccccaaa", "a2b1c5a3")]
    [InlineData("a", "a1")]
    [InlineData("abb", "a1b2")]
    [InlineData("aab", "a2b1")]
    public void SetGet(string text, string expected)
    {
        new C1Arrays_T1_6_CompressText()
            .Compress(text)
            .ShouldBe(expected);
    }
}
