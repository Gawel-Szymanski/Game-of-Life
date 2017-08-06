namespace GameOfLife
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameStateDisplay1 = new GameOfLife.GameStateDisplay();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cellPatternControl1 = new GameOfLife.CellPatternControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animationStartStopButton = new System.Windows.Forms.Button();
            this.simulationDataDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gameWindowSizeControl = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cellPaternSizeControl = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindowSizeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellPaternSizeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.89655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.10345F));
            this.tableLayoutPanel1.Controls.Add(this.gameStateDisplay1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gameStateDisplay1
            // 
            this.gameStateDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameStateDisplay1.Location = new System.Drawing.Point(3, 3);
            this.gameStateDisplay1.Name = "gameStateDisplay1";
            this.gameStateDisplay1.Size = new System.Drawing.Size(500, 668);
            this.gameStateDisplay1.TabIndex = 0;
            this.gameStateDisplay1.Text = "gameStateDisplay1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cellPatternControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(509, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.67665F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.32335F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 668);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cellPatternControl1
            // 
            this.cellPatternControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellPatternControl1.Location = new System.Drawing.Point(3, 3);
            this.cellPatternControl1.Name = "cellPatternControl1";
            this.cellPatternControl1.Size = new System.Drawing.Size(373, 239);
            this.cellPatternControl1.TabIndex = 0;
            this.cellPatternControl1.Text = "cellPatternControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 417);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.animationStartStopButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.simulationDataDisplay, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.6436F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13841F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(373, 417);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // animationStartStopButton
            // 
            this.animationStartStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationStartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.animationStartStopButton.Location = new System.Drawing.Point(3, 196);
            this.animationStartStopButton.Name = "animationStartStopButton";
            this.animationStartStopButton.Size = new System.Drawing.Size(367, 90);
            this.animationStartStopButton.TabIndex = 0;
            this.animationStartStopButton.Text = "START";
            this.animationStartStopButton.UseVisualStyleBackColor = true;
            this.animationStartStopButton.Click += new System.EventHandler(this.animationStartStopButton_Click);
            // 
            // simulationDataDisplay
            // 
            this.simulationDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.simulationDataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simulationDataDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simulationDataDisplay.Location = new System.Drawing.Point(5, 82);
            this.simulationDataDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.simulationDataDisplay.Name = "simulationDataDisplay";
            this.simulationDataDisplay.ReadOnly = true;
            this.simulationDataDisplay.Size = new System.Drawing.Size(363, 20);
            this.simulationDataDisplay.TabIndex = 1;
            this.simulationDataDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.gameWindowSizeControl, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cellPaternSizeControl, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(367, 71);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // gameWindowSizeControl
            // 
            this.gameWindowSizeControl.Location = new System.Drawing.Point(186, 38);
            this.gameWindowSizeControl.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.gameWindowSizeControl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gameWindowSizeControl.Name = "gameWindowSizeControl";
            this.gameWindowSizeControl.Size = new System.Drawing.Size(120, 22);
            this.gameWindowSizeControl.TabIndex = 3;
            this.gameWindowSizeControl.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.gameWindowSizeControl.ValueChanged += new System.EventHandler(this.gameWindowSizeControl_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Simulation Window Size";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(177, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Pattern Generator Size";
            // 
            // cellPaternSizeControl
            // 
            this.cellPaternSizeControl.Location = new System.Drawing.Point(186, 3);
            this.cellPaternSizeControl.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cellPaternSizeControl.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cellPaternSizeControl.Name = "cellPaternSizeControl";
            this.cellPaternSizeControl.Size = new System.Drawing.Size(120, 22);
            this.cellPaternSizeControl.TabIndex = 2;
            this.cellPaternSizeControl.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cellPaternSizeControl.ValueChanged += new System.EventHandler(this.cellPaternSizeControl_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Conway\'s Game of Life";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindowSizeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellPaternSizeControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GameStateDisplay gameStateDisplay1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CellPatternControl cellPatternControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button animationStartStopButton;
        private System.Windows.Forms.TextBox simulationDataDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown gameWindowSizeControl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown cellPaternSizeControl;
    }
}

