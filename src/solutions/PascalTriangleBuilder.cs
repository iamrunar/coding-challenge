using System.Text;

namespace solutions.easy;

public class PascalTriangleBuilder
{
    public IList<IList<int>> Generate(int numRows)
    {
        int[][] result = new int[numRows][]; 
        for (int r =0; r<numRows;r++)
        {
            var currentRow = result[r] = new int[r+1];
            currentRow[0] = currentRow[r] = 1;

            for (int iMiddle = 1; iMiddle < r; iMiddle++)
            {
                var lastRow = result[r - 1];
                currentRow[iMiddle]= lastRow[iMiddle - 1] + lastRow[iMiddle];
            }
        }

        return result;
    }
}
