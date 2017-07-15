using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsole
{
    class _463IslandPerimeter
    {
        public static int IslandPerimeter2(int[,] grid)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            IList<int[]> res = new List<int[]>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        res.Add(new[] {i, j});
                    }
                }
            }

            var temp = res.ToArray();
            int perimeter = 0;
            foreach (int[] t1 in temp)
            {
                int peri = 4;
                if (temp.Any(t => t[0] == t1[0] + 1 && t[1] == t1[1]))
                {
                    peri--;
                }
                if (temp.Any(t => t[0] == t1[0] - 1 && t[1] == t1[1]))
                {
                    peri--;
                }
                if (temp.Any(t => t[0] == t1[0] && t[1] == t1[1] + 1))
                {
                    peri--;
                }
                if (temp.Any(t => t[0] == t1[0] && t[1] == t1[1] - 1))
                {
                    peri--;
                }
                perimeter += peri;
            }

            return perimeter;
        }

        public static int IslandPerimeter(int[,] grid)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int result = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        result += EachGridPeri(i, j, grid);
                    }
                }
            }
            return result;
        }

        public static int EachGridPeri(int x, int y, int[,] grid)
        {
            int per = 4;
            if (x > 0)
            {
                if (grid[x - 1, y] == 1)
                {
                    per--;
                }
            }
            if (y > 0)
            {
                if (grid[x, y - 1] == 1)
                {
                    per--;
                }
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y] == 1)
                {
                    per--;
                }
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1] == 1)
                {
                    per--;
                }
            }
            return per;
        }

        public int IslandPerimeter3(int[,] grid)
        {
            int perimeter = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        if (i - 1 < 0) perimeter++;
                        else if (grid[i - 1, j] == 0) perimeter++;
                        if (i + 1 >= grid.GetLength(0)) perimeter++;
                        else if (grid[i + 1, j] == 0) perimeter++;

                        if (j - 1 < 0) perimeter++;
                        else if (grid[i, j - 1] == 0) perimeter++;
                        if (j + 1 >= grid.GetLength(1)) perimeter++;
                        else if (grid[i, j + 1] == 0) perimeter++;
                    }
                }
            }

            return perimeter;
        }
    }
}
    
