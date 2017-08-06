using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace GameOfLife
{
    public class UniformGridDisplay : Control
    {
        const int defaultGridSize = 10;

        protected Size gridSize;
        protected Point firstCell;
        protected Size cellSize;
        protected int[,] gridState;
        protected Dictionary<int, Color> colorPalette;

        public int[,] GetGridState { get { return gridState; } }

        public UniformGridDisplay()
        {
            ResizeRedraw = true;
            this.SetStyle(
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer,
               true);
            colorPalette = new Dictionary<int, Color> { };
            gridSize = new Size(defaultGridSize, defaultGridSize);
            gridState = new int[defaultGridSize, defaultGridSize];
            this.ContextMenu = new UniformGridDisplay_ContextMenu(this);
        }
        public UniformGridDisplay(int GridSize_X=defaultGridSize, int GridSize_Y=defaultGridSize)
        {
            ResizeRedraw = true;
            this.SetStyle(
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer,
               true);
            colorPalette = new Dictionary<int, Color> { };
            gridSize = new Size(GridSize_X, GridSize_Y);
            gridState = new int[GridSize_X, GridSize_Y];
        }

        public void ClearGridState()
        {
            gridState = new int[gridSize.Width, gridSize.Height];
            Invalidate();
        }

        public void UpdateGridState(int[,]nextState)
        {
            gridState = nextState;
            gridSize = new Size(nextState.GetLength(0), nextState.GetLength(1));
            CalculateLayout();
            Invalidate();
        }

        private void CalculateLayout()
        {
            int csiz = (int)Math.Floor(Math.Min((double)this.Width / gridSize.Width, (double)this.Height / gridSize.Height));
            cellSize = new Size(csiz,csiz);
            firstCell = new Point(  (this.Width - (csiz*gridSize.Width))/2,
                                    (this.Height - (csiz * gridSize.Height))/2);
        }
        protected void DrawGrid(Graphics g)
        {
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Height; y++)
                    DrawCell(g, x, y);
        }
        protected void DrawCell(Graphics g, int xCoord, int yCoord)
        {
            Rectangle rect = new Rectangle(xCoord * cellSize.Width + firstCell.X, yCoord * cellSize.Height + firstCell.Y, cellSize.Width, cellSize.Height);
            Color c;
            colorPalette.TryGetValue(gridState[xCoord, yCoord], out c);
            g.FillRectangle(new SolidBrush(c),rect);
            if (cellSize.Height > 3)
                g.DrawRectangle(new Pen(Brushes.DimGray), rect);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CalculateLayout();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGrid(e.Graphics);
        }

    }
}
