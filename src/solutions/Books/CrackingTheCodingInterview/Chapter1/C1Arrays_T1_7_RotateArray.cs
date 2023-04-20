namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_7_RotateArray
{
    public char[][] Rotate(char[][] src)
    {
        var n = src.Length;
        var outputArray = new char[n][];
        for (int j = 0; j < n; j++)
        {
            outputArray[j] = new char[n];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                outputArray[j][n - i - 1 ] = src[i][j];
            }
        }

        return outputArray;
    }
}