namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_5_IsOneModificationSolver
{
    public bool IsOneModification(string s1, string s2)
    {
        if (Math.Abs(s1.Length - s2.Length) > 1) return false;

        int l = 0, r = 0;
        int modificationCounter = 0;
        while (l<s1.Length && r<s2.Length)
        {
            if (s1[l] == s2[r])
            {
                l++; r++;
                continue;
            }

            if (l == s1.Length - 1 || r == s2.Length - 1)
            {
                break;
            }

            if (s1[l] == s2[r+1])
            {
                r++;
                modificationCounter++;
                continue;
            }

            if (s1[l+1] == s2[r])
            {
                l++;
                modificationCounter++;
                continue;
            }

            l++; r++;
            modificationCounter++;
        }
        var numberOfDifferentSymbols = Math.Abs((s1.Length - l) - (s2.Length - r));
        modificationCounter += numberOfDifferentSymbols;
        return modificationCounter <= 1;
    }

    public bool IsOneModification2(string s1, string s2)
    {
        if (Math.Abs(s1.Length - s2.Length) > 1) return false;


        //s1 - smaller than s2. s1 -- can contain removed or modified symbols, but  s2 -- can contains added or modified symbols
        // s1 = ac s2 = abc
        // s1 = xa s2 = ba
        // s1 = ab s2 = cab
        string f1, f2;
        if (s1.Length<=s2.Length)
        {
            f1 = s1;
            f2 = s2;
        }
        else
        {
            f1 = s2;
            f2 = s1;
        }

        //one modification only: replace or add new symbol
        int l = 0, r = 0;
        bool modified = false;
        while (l < f1.Length)
        {
            if (f1[l] == f2[r])
            {
                l++; r++;
            }
            else
            {
                if (modified) return false;
                modified = true;
                if (f1.Length != f2.Length)
                {
                    r++; //added
                }
                else
                {
                    //replaced 
                    l++; r++;
                }
            }
        }
        return true;
    }
}