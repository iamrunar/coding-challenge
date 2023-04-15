namespace solutions.easy;

public class PalindromeSolver
{
    public bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            var ll = Char.ToLower(s[l]);
            var rr = Char.ToLower(s[r]);
            if (!Char.IsAsciiLetterOrDigit(s[l]))
            {
                l++;
                continue;
            }
            if (!Char.IsAsciiLetterOrDigit(s[r]))
            {
                r--;
                continue;
            }
            if (ll != rr)
            {
                return false;
            }
            l++; r--;
        }
        return true;
    }
}