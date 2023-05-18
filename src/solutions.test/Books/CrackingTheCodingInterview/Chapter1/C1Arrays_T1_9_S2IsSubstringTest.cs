using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_9_S2IsSubstringTest
{
    [Theory]
    [InlineData("waterbottle", "erbottlewat", true)]
    [InlineData("waterbottle", "erbottRewat", false)]
    public void SetGet(string s1, string s2, bool expected)
    {
        new C1Arrays_T1_9_S2IsSubstringArray()
            .IsSubstring(s1,s2)
            .ShouldBe(expected);
    }
}