namespace GameOfLife
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.BChange = new System.Windows.Forms.Button();
            this.ResolutionText = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TimerText = new System.Windows.Forms.Label();
            this.GreenText = new System.Windows.Forms.Label();
            this.BlueText = new System.Windows.Forms.Label();
            this.RedText = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TBGreen = new System.Windows.Forms.TrackBar();
            this.TBBlue = new System.Windows.Forms.TrackBar();
            this.TBRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBRed)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox.DisplayMember = "1920X1080";
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1920X1080",
            "1280X720",
            "960X576"});
            this.comboBox.Location = new System.Drawing.Point(104, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            // 
            // BChange
            // 
            this.BChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChange.Location = new System.Drawing.Point(509, 98);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(114, 37);
            this.BChange.TabIndex = 1;
            this.BChange.Text = "Ghange";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // ResolutionText
            // 
            this.ResolutionText.AutoSize = true;
            this.ResolutionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResolutionText.Location = new System.Drawing.Point(16, 29);
            this.ResolutionText.Name = "ResolutionText";
            this.ResolutionText.Size = new System.Drawing.Size(82, 16);
            this.ResolutionText.TabIndex = 2;
            this.ResolutionText.Text = "Resolution";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.LargeChange = 20;
            this.trackBar.Location = new System.Drawing.Point(192, 94);
            this.trackBar.Maximum = 1000;
            this.trackBar.Minimum = 10;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(252, 45);
            this.trackBar.SmallChange = 10;
            this.trackBar.TabIndex = 3;
            this.trackBar.TickFrequency = 20;
            this.trackBar.Value = 40;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll_1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 392);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TimerText);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar);
            this.splitContainer1.Panel1.Controls.Add(this.BChange);
            this.splitContainer1.Panel1.Controls.Add(this.ResolutionText);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(637, 392);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 5;
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerText.Location = new System.Drawing.Point(16, 94);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(102, 16);
            this.TimerText.TabIndex = 4;
            this.TimerText.Text = "Timer Speed ";
            // 
            // GreenText
            // 
            this.GreenText.AutoSize = true;
            this.GreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenText.Location = new System.Drawing.Point(24, 117);
            this.GreenText.Name = "GreenText";
            this.GreenText.Size = new System.Drawing.Size(50, 16);
            this.GreenText.TabIndex = 8;
            this.GreenText.Text = "Green";
            // 
            // BlueText
            // 
            this.BlueText.AutoSize = true;
            this.BlueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueText.Location = new System.Drawing.Point(24, 66);
            this.BlueText.Name = "BlueText";
            this.BlueText.Size = new System.Drawing.Size(39, 16);
            this.BlueText.TabIndex = 7;
            this.BlueText.Text = "Blue";
            // 
            // RedText
            // 
            this.RedText.AutoSize = true;
            this.RedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedText.Location = new System.Drawing.Point(24, 15);
            this.RedText.Name = "RedText";
            this.RedText.Size = new System.Drawing.Size(37, 16);
            this.RedText.TabIndex = 6;
            this.RedText.Text = "Red";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(438, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(58, 53);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // TBGreen
            // 
            this.TBGreen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBGreen.Location = new System.Drawing.Point(99, 117);
            this.TBGreen.Maximum = 255;
            this.TBGreen.Name = "TBGreen";
            this.TBGreen.Size = new System.Drawing.Size(104, 45);
            this.TBGreen.TabIndex = 4;
            this.TBGreen.Value = 255;
            this.TBGreen.Scroll += new System.EventHandler(this.TBGreen_Scroll);
            // 
            // TBBlue
            // 
            this.TBBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBBlue.Location = new System.Drawing.Point(99, 66);
            this.TBBlue.Maximum = 255;
            this.TBBlue.Name = "TBBlue";
            this.TBBlue.Size = new System.Drawing.Size(104, 45);
            this.TBBlue.TabIndex = 3;
            this.TBBlue.Value = 255;
            this.TBBlue.Scroll += new System.EventHandler(this.TBBlue_Scroll);
            // 
            // TBRed
            // 
            this.TBRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBRed.Location = new System.Drawing.Point(99, 15);
            this.TBRed.Maximum = 255;
            this.TBRed.Name = "TBRed";
            this.TBRed.Size = new System.Drawing.Size(104, 45);
            this.TBRed.TabIndex = 2;
            this.TBRed.Value = 255;
            this.TBRed.Scroll += new System.EventHandler(this.TBRed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel.Controls.Add(this.RedText);
            this.panel.Controls.Add(this.TBRed);
            this.panel.Controls.Add(this.GreenText);
            this.panel.Controls.Add(this.TBBlue);
            this.panel.Controls.Add(this.BlueText);
            this.panel.Controls.Add(this.TBGreen);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(19, 64);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(604, 168);
            this.panel.TabIndex = 10;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(640, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OptionForm";
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBRed)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.Label ResolutionText;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label TimerText;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar TBGreen;
        private System.Windows.Forms.TrackBar TBBlue;
        private System.Windows.Forms.TrackBar TBRed;
        private System.Windows.Forms.Label GreenText;
        private System.Windows.Forms.Label BlueText;
        private System.Windows.Forms.Label RedText;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
    }
}