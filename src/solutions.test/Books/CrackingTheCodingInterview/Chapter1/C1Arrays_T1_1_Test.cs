using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_1_Test
{
    [Theory]
    [InlineData("", true)]
    [InlineData("a", true)]
    [InlineData("aba", false)]
    [InlineData("a!b", true)]
    [InlineData("a!b!", false)]
    [InlineData("aaaaa\n\naa", false)]
    [InlineData("a!b$#@213", true)]
    [InlineData("фбв", true)]
    [InlineData("ыфйеы", false)]
    public void T1_1_AllSymbolsIsUnique(string text, bool expected)
    {
        new C1Arrays_T1_1_AllSymbolsIsUniqueSolver()
            .CheckThatAllSymbolsIsUnique(text)
            .ShouldBe(expected);
        new C1Arrays_T1_1_AllSymbolsIsUniqueSolver()
            .CheckThatAllSymbolsIsUnique2(text)
            .ShouldBe(expected);
    }
}
