using Shouldly;
using solutions.Books.CrackingTheCodingInterview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_3_Test
{
    [Theory]
    [InlineData("Mr John Smith    ", 13, "Mr%20John%20Smith")]
    public void SetGet(string s1, int len, string expected)
    {
        var sb = new StringBuilder(s1);
        new C1Arrays_T1_3_ReplaceSpaceToP20()
            .Replace(sb, len);

        sb
            .ToString()
            .ShouldBe(expected);

    }
}
