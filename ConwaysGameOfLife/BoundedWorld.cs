using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class BoundedWorld : Board
    {
        private Cell[,] cells;
        public int Height { get; set; }
        public int Width { get; set; }

        public BoundedWorld()
        {
        }

        public BoundedWorld(int width, int height)
        {
            cells = new Cell[height, width];
            Width = width;
            Height = height;
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cells[row, col] = new Cell();
                }
            }
        }

        public List<List<bool>> ToList()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public int DeadCellCount()
        {
            int result = 0;
            
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (!cells[row,col].IsAlive)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public int AliveCellCount()
        {
            return (Width * Height) - DeadCellCount();
        }

        public void AddCell(int x, int y)
        {
            cells[y, x].IsAlive = true;
        }

        public void UnderPopulationRule()
        {
            throw new NotImplementedException();
        }

        private bool IsCellAlive(Cell c)
        {
            return c.IsAlive;
        }

        // this can be refactored later
        public int AliveNeighborCount(int x, int y)
        {
            Cell above, below, right, left;
            Cell top_right, top_left, bottom_left, bottom_right;
            List<Cell> neighbors = new List<Cell>();

            // x, y are in "row, column" order, not Cartesian coordinates!
            above = cells[y, x - 1];
            below = cells[y, x + 1];
            right = cells[y + 1, x];
            left = cells[y - 1, x];
            top_right = cells[y + 1, x - 1];
            top_left = cells[y - 1, x - 1];
            bottom_right = cells[y + 1, x + 1];
            bottom_left = cells[y - 1, x + 1];

            neighbors.Add(above);
            neighbors.Add(below);
            neighbors.Add(right);
            neighbors.Add(left);
            neighbors.Add(top_left);
            neighbors.Add(top_right);
            neighbors.Add(bottom_left);
            neighbors.Add(bottom_right);

            return neighbors.FindAll(IsCellAlive).Count;            
        }
    }
}
