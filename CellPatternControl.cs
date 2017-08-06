using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    class CellPatternControl : UniformGridDisplay
    {
        Color liveCell = Color.LawnGreen;
        Color deadCell = Color.Black;
        public CellPatternControl()
        {
            colorPalette.Add(0, deadCell);
            colorPalette.Add(1, liveCell);
            this.MouseClick += CellPatternControl_MouseClick;
        }

        private void CellPatternControl_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button.Equals(MouseButtons.Left))
                UpdateCell(e);
        }

        private void UpdateCell(MouseEventArgs e)
        {
            if (e.X < firstCell.X || e.Y < firstCell.Y || e.X >= firstCell.X + cellSize.Width * gridSize.Width || e.Y >= firstCell.Y + firstCell.Y + cellSize.Width * gridSize.Height)
                return;
            Point cellCoordinates = new Point(
                (int)Math.Floor((double)(e.X-firstCell.X)/cellSize.Width), 
                (int)Math.Floor((double)(e.Y-firstCell.Y)/cellSize.Height)
                );
            gridState[cellCoordinates.X, cellCoordinates.Y]++;
            gridState[cellCoordinates.X, cellCoordinates.Y] %= 2;
            Invalidate();
        }

    }
}
