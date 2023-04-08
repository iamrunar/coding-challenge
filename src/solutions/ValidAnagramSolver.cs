namespace solutions.easy;

public class ValidAnagramSolver
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        //int: 1 <= s.length, t.length <= 5 * 104
        int[] hashtable = new int[26];

        foreach (var c in s)
        {
            ++hashtable[c - 'a'];
        }

        foreach (var c in t)
        {
            if (--hashtable[c - 'a']<0)
            {
                return false;
            }
        }

        return true;
    }
}