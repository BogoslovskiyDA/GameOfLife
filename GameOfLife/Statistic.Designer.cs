namespace GameOfLife
{
    partial class Statistic
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
            this.components = new System.ComponentModel.Container();
            this.diagram = new System.Windows.Forms.PictureBox();
            this.TimerForDiagram = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagram
            // 
            this.diagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram.Location = new System.Drawing.Point(0, 0);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(584, 627);
            this.diagram.TabIndex = 0;
            this.diagram.TabStop = false;
            // 
            // TimerForDiagram
            // 
            this.TimerForDiagram.Interval = 40;
            this.TimerForDiagram.Tick += new System.EventHandler(this.TimerForDiagram_Tick);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 627);
            this.Controls.Add(this.diagram);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Statistic";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.Timer TimerForDiagram;
    }
}