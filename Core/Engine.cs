using System.Windows.Automation;

namespace LeJeuDeLaVie.Core
{
    internal class Engine
    {

        private static int CountNeighbor(bool[,] grid, int colPos, int rowPos)
        {
            var neighborCount = 0;

            var tmpColPos = colPos - 1;
            var tmpRowPos = rowPos - 1;
            if (tmpColPos < 0)
            {
                tmpColPos = 0;
            }
            if (tmpRowPos < 0)
            {
                tmpRowPos = 0;
            }

            while (tmpColPos <= colPos + 1)
            {
                while (tmpRowPos <= rowPos + 1)
                {
                    if (tmpRowPos < grid.GetLength(0) - 1)
                    {
                        if (grid[tmpRowPos, tmpColPos] && (tmpRowPos != rowPos || tmpColPos != colPos))
                        {
                            neighborCount++;
                        }
                        tmpRowPos++;
                    }
                    else
                        tmpRowPos = rowPos + 10;
                }

                if (tmpColPos < grid.GetLength(1) - 1)
                {
                    tmpColPos++;
                    tmpRowPos = rowPos - 1;
                    if (tmpRowPos < 0)
                    {
                        tmpRowPos = 0;
                    }

                }
                else
                    tmpColPos = colPos + 10;
            }
            return neighborCount;
        }

        public static bool CheckCellValue(bool[,] grid, int colPos, int rowPos)
        {
            var neighborCount = CountNeighbor(grid, colPos, rowPos);

            if (grid[rowPos, colPos] == true && neighborCount <= 1)
                return false;
            if (grid[rowPos, colPos] == true && neighborCount == 2)
                return true;
            if (grid[rowPos, colPos] == true && neighborCount >= 3)
                return false;
            if (grid[rowPos, colPos] == false && neighborCount is 2)
                return true;

            return grid[rowPos,colPos];
        }
    }
}
