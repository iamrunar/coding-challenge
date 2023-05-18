namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_8_RowColNullArray
{
    public char[][] CheckAndNull(char[][] chars)
    {
        //MEM: O(K)
        //CPU: O(2K)

        //CPU: O(m*n+(m+n)*Z)
        FindZeroAndFillColAndRow();
        //CPU: O(m*n)
        FindNullAndReplace();

        //CPU: O((m*n)+(m*n)+(m+n)*Z) = O(2K)

        return chars;

        //
        void FindZeroAndFillColAndRow()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (chars[i][j] == '0')
                    {
                        SetNull(i, j);
                        break;
                    }
                }
            }
        }

        void SetNull(int row, int col)
        {
            for (int r = 0; r < chars.Length; r++)
            {
                chars[r][col] = '\0';
            }
            for (int c = 0; c < chars[row].Length; c++)
            {
                chars[row][c] = '\0';
            }
        }

        void FindNullAndReplace()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (chars[i][j] == '\0')
                    {
                        chars[i][j] = '0';
                    }
                }
            }
        }
    }
    public char[][] CheckAndNull2(char[][] chars)
    {
        bool[] whereZeroInRows = new bool[chars.Length];    //projection from all rows
        bool[] whereZeroInColumns = new bool[chars[0].Length]; //projection from all columns

        for (int i = 0; i < chars.Length; i++)
            for (int j = 0; j < chars[0].Length; j++)
            {
                if (chars[i][j] == '0')
                {
                    whereZeroInRows[i] = true;
                    whereZeroInColumns[j] = true;
                    break;
                }
            }

        for (int i = 0; i < whereZeroInRows.Length; i++)
        {
            if (whereZeroInRows[i])
            {
                NullifyRow(i);
            }
        }

        for (int j = 0; j < whereZeroInColumns.Length; j++)
        {
            if (whereZeroInColumns[j])
            {
                NullifyCol(j);
            }
        }

        return chars;


        void NullifyRow(int row)
        {
            for (int c = 0; c < chars[0].Length; c++)
            {
                chars[row][c] = '0';
            }
        }

        void NullifyCol(int col)
        {
            for (int r = 0; r < chars.Length; r++)
            {
                chars[r][col] = '0';
            }
        }
    }
}