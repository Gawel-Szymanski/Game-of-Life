using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOfLife
{
    class GameStateDisplay : UniformGridDisplay
    {
        private Color liveCellColor = Color.LawnGreen;
        private Color deadCellColor = Color.Black;
        private int liveCellCount;
        private int deadCellCount;

        public GameStateDisplay()
        {
            colorPalette.Add(0, deadCellColor);
            colorPalette.Add(1, liveCellColor);
            this.MouseClick += GameStateDisplay_MouseClick;
        }

        public void ExpandGrid(int expandedSize)
        {
            int[,] expanded = new int[expandedSize, expandedSize];
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Height; y++)
                    expanded[x + (int)Math.Floor((double)(expandedSize-gridSize.Width)/2), y+(int)Math.Floor((double)(expandedSize-gridSize.Height) / 2)] = gridState[x, y];
            UpdateGridState(expanded);
        }

        private void GameStateDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (UniformGridDisplay_ContextMenu.clipboard != null)
            {
                InsertPatternFromClipboard(e);
                Invalidate();
            }
        }

        private void InsertPatternFromClipboard(MouseEventArgs e)
        {
            if (e.X < firstCell.X || e.Y < firstCell.Y || e.X > firstCell.X + cellSize.Width * gridSize.Width || e.Y > firstCell.Y + firstCell.Y + cellSize.Width * gridSize.Height)
                return;
            Point patternStart = new Point(
                (int)Math.Floor((double)(e.X - firstCell.X) / cellSize.Width),
                (int)Math.Floor((double)(e.Y - firstCell.Y) / cellSize.Height)
                );

            for (int x = 0; x < UniformGridDisplay_ContextMenu.clipboard.GetLength(0); x++)
                for (int y = 0; y < UniformGridDisplay_ContextMenu.clipboard.GetLength(1); y++)
                {
                    gridState[(patternStart.X + x) % gridSize.Width, (patternStart.Y + y) % gridSize.Height] = UniformGridDisplay_ContextMenu.clipboard[x, y];
                }
        }

        public object GetLiveCells => liveCellCount;
        public object GetDeadCells => deadCellCount;
        public void NextIteration()
        {
            liveCellCount = 0;
            deadCellCount = 0;
            int[,] nextState = new int[gridSize.Width, gridSize.Height];
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Height; y++)
                {
                    int live_neighbors = 0;
                    switch (gridState[x, y])
                    {
                        case 0:
                            for (int dx = -1; dx <= 1; dx++)
                                for (int dy = -1; dy <= 1; dy++)
                                {
                                    if (gridState[(x + dx + gridSize.Width) % gridSize.Width, (y+ dy + gridSize.Height) % gridSize.Height] == 1)
                                        live_neighbors++;
                                }
                            if (live_neighbors == 3)
                            {
                                nextState[x, y] = 1;
                                liveCellCount++;
                            }
                            else
                            {
                                deadCellCount++;
                            }
                            break;
                        case 1:
                            for (int dx = -1; dx <= 1; dx++)
                                for (int dy = -1; dy <= 1; dy++)
                                {
                                    if (gridState[(x + dx + gridSize.Width) % gridSize.Width, (y + dy + gridSize.Height) % gridSize.Height] == 1)
                                        live_neighbors++;
                                }
                            if (live_neighbors == 3 || live_neighbors == 4)
                            {
                                nextState[x, y] = 1;
                                liveCellCount++;
                            }
                            else
                            {
                                nextState[x, y] = 0;
                                deadCellCount++;
                            }
                            break;
                        default:
                            throw new Exception(string.Format("Invalid cell state at {0},{1}: cell state is {2}", x, y, gridState[x, y]));
                    }
                }
            UpdateGridState(nextState);
        }

    }
}
