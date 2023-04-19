using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_2_Test
{
    [Theory]
    [InlineData("a", "a", true)]
    [InlineData("abc", "cab", true)]
    [InlineData("abc", "cla", false)]
    [InlineData("aab", "bab", false)]
    [InlineData("aab", "a", false)]
    [InlineData("ac", "ca", false)]
    [InlineData("aa", "a", false)]
    [InlineData("a", "aa", false)]
    [InlineData("aba", "bab", false)]
    public void T1_1_AllSymbolsIsUnique(string s1, string s2, bool expected)
    {
        new C1Arrays_T1_2_PolindromSolver()
            .IsPolindrom(s1, s2)
            .ShouldBe(expected);
    }
}
