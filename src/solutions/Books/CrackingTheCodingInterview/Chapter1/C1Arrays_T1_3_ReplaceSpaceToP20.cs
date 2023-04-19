using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_3_ReplaceSpaceToP20
{
    public void Replace(StringBuilder s1, int length)
    {
        //%20
        for (int j = length-1, i = s1.Length-1; j>= 0; j--)
        {
            if (s1[j] == ' ')
            {
                s1[i-2] = '%';
                s1[i-1] = '2';
                s1[i] = '0';
                i -= 3;
            }
            else
            {
                s1[i] = s1[j];
                --i;
            }
        }
    }
}
