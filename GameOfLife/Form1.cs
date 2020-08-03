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
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;
        private int currentGeneration = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (Timer.Enabled)
                return;

            currentGeneration = 0;
            Text = $"Generation {currentGeneration}";

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            resolution = (int)nudResolution.Value;
            rows = pictureBox.Height / resolution;
            cols = pictureBox.Width / resolution;
            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nudDensity.Value) == 0;
                }
            }

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            Timer.Start();
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newfield = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                        newfield[x, y] = true;
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newfield[x, y] = false;
                    else
                        newfield[x, y] = field[x, y];

                    if (hasLife)
                        graphics.FillRectangle(Brushes.White, x * resolution, y * resolution, resolution, resolution);
                }
            }

            //Random random = new Random();
            //for (int x = 0; x < cols; x++)
            //{
            //    for (int y = 0; y < rows; y++)
            //    {
            //        field[x, y] = random.Next((int)nudDensity.Value) == 0;
            //    }
            //}

            field = newfield;
            pictureBox.Refresh();
            Text = $"Generation {++currentGeneration}";
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }

            return count;
        }

        private void StopGame()
        {
            if (!Timer.Enabled)
                return;
            Timer.Stop();
            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Timer.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMusePosition(x, y);
                if (validationPassed)
                    field[x, y] = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMusePosition(x, y);
                if (validationPassed)
                    field[x, y] = false;
            }
        }

        private bool ValidateMusePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Generation {currentGeneration}";
        }
    }
}
