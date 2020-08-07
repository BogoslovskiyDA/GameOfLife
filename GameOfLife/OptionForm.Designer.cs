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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.TBRed = new System.Windows.Forms.TrackBar();
            this.TBBlue = new System.Windows.Forms.TrackBar();
            this.TBGreen = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.comboBox.Location = new System.Drawing.Point(104, 23);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            // 
            // BChange
            // 
            this.BChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChange.Location = new System.Drawing.Point(512, 165);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(114, 37);
            this.BChange.TabIndex = 1;
            this.BChange.Text = "Ghange";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resolution";
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.TBGreen);
            this.splitContainer1.Panel2.Controls.Add(this.TBBlue);
            this.splitContainer1.Panel2.Controls.Add(this.TBRed);
            this.splitContainer1.Panel2.Controls.Add(this.BChange);
            this.splitContainer1.Size = new System.Drawing.Size(638, 392);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timer Speed ";
            // 
            // TBRed
            // 
            this.TBRed.Location = new System.Drawing.Point(33, 49);
            this.TBRed.Maximum = 255;
            this.TBRed.Name = "TBRed";
            this.TBRed.Size = new System.Drawing.Size(104, 45);
            this.TBRed.TabIndex = 2;
            this.TBRed.Value = 255;
            this.TBRed.Scroll += new System.EventHandler(this.TBRed_Scroll);
            // 
            // TBBlue
            // 
            this.TBBlue.Location = new System.Drawing.Point(33, 100);
            this.TBBlue.Maximum = 255;
            this.TBBlue.Name = "TBBlue";
            this.TBBlue.Size = new System.Drawing.Size(104, 45);
            this.TBBlue.TabIndex = 3;
            this.TBBlue.Value = 255;
            this.TBBlue.Scroll += new System.EventHandler(this.TBBlue_Scroll);
            // 
            // TBGreen
            // 
            this.TBGreen.Location = new System.Drawing.Point(33, 157);
            this.TBGreen.Maximum = 255;
            this.TBGreen.Name = "TBGreen";
            this.TBGreen.Size = new System.Drawing.Size(104, 45);
            this.TBGreen.TabIndex = 4;
            this.TBGreen.Value = 255;
            this.TBGreen.Scroll += new System.EventHandler(this.TBGreen_Scroll);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(379, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(58, 53);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(641, 392);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar TBGreen;
        private System.Windows.Forms.TrackBar TBBlue;
        private System.Windows.Forms.TrackBar TBRed;
    }
}