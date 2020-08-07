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
    public partial class OptionForm : Form
    {
        Form1 form;
        Timer timer;
        //public Brush brush;
        private int Red = 255;
        private int Blue = 255;
        private int Green = 255;
        //public Color color;
        Graphics graphics;

        public OptionForm(Form1 form, Timer timer)
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
            this.form = form;
            MaximizeBox = false;
            MinimizeBox = false;
            this.timer = timer;
            label2.Text = "Timer Speed " + trackBar.Value;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
        }

        public void GetScreenResolution()
        {
            var size = comboBox.Text;
            var x = size.Split('X');
            form.Width = int.Parse(x[0]);
            form.Height = int.Parse(x[1]);
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            //var b = new SolidBrush(Color.FromArgb(255, Red, Green, Blue));
            GetScreenResolution();
            timer.Interval = trackBar.Value;
            //brush = b;
        }

        private void trackBar_Scroll_1(object sender, EventArgs e)
        {
            label2.Text = "Timer Speed " + trackBar.Value;
        }

        private void TBRed_Scroll(object sender, EventArgs e)
        {
            Red = TBRed.Value;
            pictureBox.BackColor = Color.FromArgb(255, Red, Green, Blue);
            pictureBox.Refresh();
        }

        private void TBBlue_Scroll(object sender, EventArgs e)
        {
            Blue = TBBlue.Value;
            pictureBox.BackColor = Color.FromArgb(255, Red, Green, Blue);
            pictureBox.Refresh();
        }

        private void TBGreen_Scroll(object sender, EventArgs e)
        {
            Green = TBGreen.Value;
            pictureBox.BackColor = Color.FromArgb(255, Red, Green, Blue);
            pictureBox.Refresh();
        }
    }
}
