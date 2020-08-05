namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BPause = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowStatistic = new System.Windows.Forms.Button();
            this.BStop = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ShowStatistic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 701);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // BPause
            // 
            this.BPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPause.Location = new System.Drawing.Point(143, 176);
            this.BPause.Name = "BPause";
            this.BPause.Size = new System.Drawing.Size(37, 37);
            this.BPause.TabIndex = 8;
            this.BPause.Text = "⏸️";
            this.BPause.UseVisualStyleBackColor = true;
            this.BPause.Click += new System.EventHandler(this.BPause_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Living Cells :";
            // 
            // ShowStatistic
            // 
            this.ShowStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowStatistic.Location = new System.Drawing.Point(16, 367);
            this.ShowStatistic.Name = "ShowStatistic";
            this.ShowStatistic.Size = new System.Drawing.Size(117, 37);
            this.ShowStatistic.TabIndex = 6;
            this.ShowStatistic.Text = "Show Diagram";
            this.toolTip.SetToolTip(this.ShowStatistic, "Plotting the number of living cells");
            this.ShowStatistic.UseVisualStyleBackColor = true;
            this.ShowStatistic.Click += new System.EventHandler(this.ShowStatistic_Click);
            // 
            // BStop
            // 
            this.BStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStop.Location = new System.Drawing.Point(6, 197);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(131, 37);
            this.BStop.TabIndex = 5;
            this.BStop.Text = "Close Game";
            this.BStop.UseVisualStyleBackColor = true;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // BStart
            // 
            this.BStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(6, 154);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(131, 37);
            this.BStart.TabIndex = 4;
            this.BStart.Text = "Start New Game";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(34, 105);
            this.nudDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(120, 20);
            this.nudDensity.TabIndex = 3;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(34, 39);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(120, 20);
            this.nudResolution.TabIndex = 1;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(950, 697);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // Timer
            // 
            this.Timer.Interval = 40;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BPause);
            this.panel1.Controls.Add(this.nudResolution);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudDensity);
            this.panel1.Controls.Add(this.BStop);
            this.panel1.Controls.Add(this.BStart);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 257);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Generation :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 701);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button ShowStatistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button BPause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

