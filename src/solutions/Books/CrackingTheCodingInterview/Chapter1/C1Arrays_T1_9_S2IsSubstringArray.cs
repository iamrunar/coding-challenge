namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_9_S2IsSubstringArray
{
    public bool IsSubstring(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;

        var s2concat = s2 + s2;

        return s2concat.Contains(s1);
    }
}
