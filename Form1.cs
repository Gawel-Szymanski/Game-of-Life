using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cellPatternControl1.UpdateGridState(new int[(int)cellPaternSizeControl.Value, (int)cellPaternSizeControl.Value]);
            gameStateDisplay1.UpdateGridState(new int[(int)gameWindowSizeControl.Value, (int)gameWindowSizeControl.Value]);
        }
        public double elapsedTime = 0;
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameStateDisplay1.NextIteration();
            elapsedTime += GameTimer.Interval;
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            simulationDataDisplay.Text = string.Format("Live cells: {0}, dead cells: {1}", 
                                                        gameStateDisplay1.GetLiveCells,
                                                        gameStateDisplay1.GetDeadCells);
        }

        private void animationStartStopButton_Click(object sender, EventArgs e)
        {
            if (animationStartStopButton.Text == "START")
            {
                animationStartStopButton.Text = "PAUSE";
                GameTimer.Start();
            }
            else
            {
                animationStartStopButton.Text = "START";
                GameTimer.Stop();
            }
        }

        private void cellPaternSizeControl_ValueChanged(object sender, EventArgs e)
        {
            cellPatternControl1.UpdateGridState(new int[(int)cellPaternSizeControl.Value, (int)cellPaternSizeControl.Value]);
        }

        private void gameWindowSizeControl_ValueChanged(object sender, EventArgs e)
        {
            if ((int)gameWindowSizeControl.Value < gameStateDisplay1.GetGridState.GetLength(0))
            {
                gameStateDisplay1.UpdateGridState(new int[(int)gameWindowSizeControl.Value, (int)gameWindowSizeControl.Value]);
                return;
            }
            gameStateDisplay1.ExpandGrid((int)gameWindowSizeControl.Value);
        }
    }
}
