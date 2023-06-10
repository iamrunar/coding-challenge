using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_5_Test
{
    [Theory]
    [InlineData("pale", "palesss", false)]
    //from book
    [InlineData("pale", "ple", true)]
    [InlineData("pales", "pale", true)]
    [InlineData("pale", "bale", true)]
    [InlineData("pale", "bake", false)]

    //added
    [InlineData("pale", "pacle", true)]
    [InlineData("pale", "pales", true)]
    [InlineData("pale", "apale", true)]

    //removed
    //[InlineData("pale", "ple", true)]
    [InlineData("pale", "pal", true)]
    [InlineData("pale", "ale", true)]

    //replaced
    [InlineData("pale", "pake", true)]
    [InlineData("pale", "pals", true)]
    //[InlineData("pale", "bale", true)]
    public void SetGet(string s1, string s2, bool expected)
    {
        new C1Arrays_T1_5_IsOneModificationSolver()
            .IsOneModification(s1,s2)
            .ShouldBe(expected);
        new C1Arrays_T1_5_IsOneModificationSolver()
            .IsOneModification2(s1, s2)
            .ShouldBe(expected);
    }
}
