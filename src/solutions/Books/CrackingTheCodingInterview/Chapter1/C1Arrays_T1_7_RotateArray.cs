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

    public char[][] Rotate2(char[][] src)
    {
        //todo
        int n = src.Length, nn = n;
        for (int layer=0;layer < n /2; layer++, nn-=2)
        {
            int r = layer;
            for (int i=0; i<nn; i++)
            {
                int nq = nn - 1;
                char a = src[r][i];
                src[r][i] = src[i][nq - r];
                src[i][nq - r] = src[nq - r][nq - i];
                src[nq - r][nq - i] = src[i][r];
                src[r][i] = a;
            }
        }

        return src;
    }
}
