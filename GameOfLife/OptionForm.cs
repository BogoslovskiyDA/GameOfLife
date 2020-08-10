using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class OptionForm : Form
    {
        readonly Form1 form;
        readonly Timer timer;
        private int Red = 255;
        private int Blue = 255;
        private int Green = 255;
        readonly MyBrushColor myBrush;

        public OptionForm(Form1 form, Timer timer, MyBrushColor myBrush)
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
            this.form = form;
            MaximizeBox = false;
            MinimizeBox = false;

            this.timer = timer;
            trackBar.Value = timer.Interval;
            TimerText.Text = "Timer Speed " + trackBar.Value;

            this.myBrush = myBrush;
            TBRed.Value = myBrush.Red;
            TBGreen.Value = myBrush.Green;
            TBBlue.Value = myBrush.Blue;


            var size = $"{form.Width}X{form.Height}";
            comboBox.SelectedItem = size;

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.BackColor = Color.FromArgb(255, TBRed.Value, TBGreen.Value, TBBlue.Value);
        }

        public void GetScreenResolution()
        {
            var size = comboBox.Text;
            var x = size.Split('X');
            if (form.Width == int.Parse(x[0]) && form.Height == int.Parse(x[1]))
                return;
            form.Width = int.Parse(x[0]);
            form.Height = int.Parse(x[1]);
            Point point = new Point(0, 0);
            form.DesktopLocation = point;
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            GetScreenResolution();
            timer.Interval = trackBar.Value;
            myBrush.Red = Red;
            myBrush.Green = Green;
            myBrush.Blue = Blue;
        }

        private void trackBar_Scroll_1(object sender, EventArgs e)
        {
            TimerText.Text = "Timer Speed " + trackBar.Value;
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
